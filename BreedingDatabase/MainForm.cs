using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace BreedingDatabase
{
    public partial class MainForm : Form
    {
        private static readonly int[] BatchSizes = new int[] { 5, 10, 20 };
        private const string DatabaseFile = "breeding.db";

        private readonly ILiteDatabase database;
        private readonly ILiteCollection<Artist> artists;
        private readonly ILiteCollection<Batch> batches;
        private readonly ILiteCollection<Breeding> breedings;

        private bool IsCreateBatchEnabled
        {
            // simple check, are there 5 10 or 20 selected rows
            get => BatchSizes.Contains(newIdsGridView.SelectedRows.Count);
        }

        public MainForm()
        {
            InitializeComponent();

            // create the config file at startup
            Properties.Settings.Default.Save();

            database = new LiteDatabase(DatabaseFile);
            artists = database.GetCollection<Artist>();
            batches = database.GetCollection<Batch>();
            breedings = database.GetCollection<Breeding>();

            // make sure the User Prediction Artist exists
            artists.Upsert(Artist.UserArtist);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FillGrid();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            if (disposing && database != null)
            {
                database.Dispose();
            }

            string backup = Path.Combine(Environment.ExpandEnvironmentVariables(Properties.Settings.Default.BackupLocation), DatabaseFile);
            File.Copy(DatabaseFile, backup, true);
        }

        private void FillGrid()
        {
            artistBindingSource.DataSource = 
                artists.Query().ToEnumerable();
            newIdsGridView.DataSource = new BindingList<Breeding>(
                breedings.Query().Where(b => b.Batch == null).OrderBy(b => b.Id).ToList());
            breedingBindingSource.DataSource = 
                breedings.Query().Where(b => b.Batch != null).Include(b => b.Artist).Include(b => b.Batch).ToEnumerable().OrderByDescending(b => b.Batch.BatchDate).ThenBy(b => b.Ordering);
        }

        private void HandleException(Exception e)
        {
            System.IO.File.WriteAllText("Error.Log", e.ToString());
            MessageBox.Show(
                "An exception occured while interacting with the database, no changes were made to protect the data. Give Dos the Error.Log file created in the program directory.",
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private Breeding GetBreedingFromGrid(int index)
        {
            if (index < 0 || index >= breedingBindingSource.Count) return null;
            return breedingBindingSource[index] as Breeding;
        }

        private bool IsRepeatedBatchRow(int index)
        {
            // first row is not repeated
            // just return false if out of bounds
            if (index <= 0 || index >= breedingBindingSource.Count) return false;

            // check the row above
            return GetBreedingFromGrid(index)?.Batch?.Id.Equals(GetBreedingFromGrid(index - 1)?.Batch?.Id) ?? false;
        }

        private void BreedingGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // get the breeding for this row or bail
            Breeding breeding = GetBreedingFromGrid(e.RowIndex);
            if (breeding == null) return;

            // handle the columns
            if (e.ColumnIndex == breedingTypeColumn.Index)
            {
                e.CellStyle.BackColor = breeding.BreedingType.GetColor();
                e.Value = breeding.BreedingType.GetName();
            }
            else if (e.ColumnIndex == isRareColumn.Index)
            {
                if (breeding.BreedingType == BreedingType.Mutant || breeding.BreedingType == BreedingType.Unrolled)
                {
                    e.Value = string.Empty;
                }
                else
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml(breeding.IsRare ? "#b7e1cd" : "#f7c7c3");
                    e.Value = breeding.IsRare ? "yes" : "no";
                }
            }
            else if (e.ColumnIndex == rolledXaocColumn.Index)
            {
                if (breeding.BreedingType == BreedingType.Mutant || breeding.BreedingType == BreedingType.Unrolled)
                {
                    e.Value = string.Empty;
                }
                else
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml(breeding.RolledXaoc ? "#b7e1cd" : "#f7c7c3");
                    e.Value = breeding.RolledXaoc ? "yes" : "no";
                }
            }
            else if (e.ColumnIndex == batchColumn.Index)
            {
                if (breeding.Batch == null)
                {
                    e.Value = "-";
                }
                else
                {
                    e.Value = IsRepeatedBatchRow(e.RowIndex) ? string.Empty : breeding.Batch.BatchDate.ToString("D");
                    breedingGridView[e.ColumnIndex, e.RowIndex].ToolTipText = breeding.Batch.BatchDate.ToString("F");
                }
            }
            else if (e.ColumnIndex == artistColumn.Index)
            {
                //e.Value = breeding.Artist?.Id;

            }
        }

        private void BreedingGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // all cells and headers are centers all the time
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // get the breeding for this row or bail
            Breeding breeding = GetBreedingFromGrid(e.RowIndex);
            if (breeding == null) return;

            // just the batch column
            if (e.ColumnIndex == batchColumn.Index)
            {
                if (IsRepeatedBatchRow(e.RowIndex))
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                }
                if (e.RowIndex + 1 < breedingBindingSource.Count && 
                    (breeding.Batch?.Id.Equals((breedingBindingSource[e.RowIndex + 1] as Breeding)?.Batch?.Id) ?? false))
                {
                    e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
                }
            }
        }

        private void CreateBatchButton_Click(object sender, EventArgs e)
        {
            // sanity check
            if (!IsCreateBatchEnabled) return;

            // confirm with Alana
            if (MessageBox.Show(this, "Do you want to create a new batch with the selected breedings?", "Create Batch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            // so some more validation
            IEnumerable<Breeding> batchBreedings = newIdsGridView.SelectedRows.Cast<DataGridViewRow>().Select(r => (Breeding)r.DataBoundItem);
            int batchSize = batchBreedings.Count();

            // make sure there aren't too many oozes
            int oozeCount = newIdsGridView.SelectedRows.Cast<DataGridViewRow>().Where(r => ((Breeding)r.DataBoundItem).IsMooze).Count();
            if (oozeCount > 0.8 * batchSize)
            {
                MessageBox.Show(this, $"There are too many Mutagenic Oozes for a {batchSize} batch.", "Too much Ooze!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // find the first unselected row to see if the batch is the oldest rows
            int index = 0;
            for (; index < newIdsGridView.RowCount; index++)
            {
                if (!newIdsGridView.Rows[index].Selected) break;
            }

            // check if index matches a batch size
            if (!BatchSizes.Contains(index) &&
                MessageBox.Show(this, "There are older breedings not included in this batch, are you sure you want to continue?",
                    "Double Checking", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                database.BeginTrans();
                Batch batch = new Batch();
                batches.Insert(batch);
                foreach (Breeding breeding in batchBreedings)
                {
                    // calc the hash to sort the breedings by
                    breeding.CalcOrdering();
                    breeding.BreedingType = BreedingType.Mutant;
                    breeding.Batch = batch;
                    breeding.RollXaoc();
                }

                List<Breeding> sortedBatch = new List<Breeding>(batchSize);
                IEnumerator<Breeding> mooze = batchBreedings.Where(b => b.IsMooze).OrderBy(b => b.Ordering).GetEnumerator();
                IEnumerator<Breeding> nonMooze = batchBreedings.Where(b => !b.IsMooze).OrderBy(b => b.Ordering).GetEnumerator();
                for (int i = 0; i < batchSize; i++) {
                    if (i % 5 != 4 && mooze.MoveNext()) 
                    {
                        sortedBatch.Add(mooze.Current);
                    }
                    else if (nonMooze.MoveNext())
                    {
                        sortedBatch.Add(nonMooze.Current);
                    }
                    else
                    {
                        throw new Exception("Ran out of breedings while building the sorted list!");
                    }
                }

                // every 5 is special
                for (int i = 4; i < sortedBatch.Count; i += 5)
                {
                    Breeding special = sortedBatch[i];
                    special.RollRare();
                    special.SetTypeFromIndex(i);
                }

                // fix the 5 batch to roll type
                if (sortedBatch.Count == 5)
                {
                    Breeding special = sortedBatch[4];
                    special.RollBreedingType();
                }

                breedings.Update(sortedBatch);

                database.Commit();
                database.Checkpoint();
            }
            catch (Exception ex)
            {
                HandleException(ex);
                database.Rollback();
            }

            // refresh
            FillGrid();
        }

        private void NewIdsGridView_SelectionChanged(object sender, EventArgs e)
        {
            createBatchButton.Enabled = IsCreateBatchEnabled;
        }

        private void AddNewIds(IEnumerable<string> ids)
        {
            List<long> newIds = new List<long>();
            foreach (string idStr in ids)
            {
                if (!long.TryParse(idStr, out long id)) continue;

                if (breedings.Exists(b => b.Id == id)) continue;

                newIds.Add(id);
            }

            if (newIds.Count == 0) return;

            database.BeginTrans();
            try
            {
                breedings.Insert(newIds.Select(id => new Breeding() { Id = id }));
                database.Commit();
                database.Checkpoint();
            }
            catch (Exception e)
            {
                database.Rollback();
                HandleException(e);
            }

            FillGrid();
        }

        private void ParseNewIds(string text)
        {
            Regex regex = new Regex(@"<a href=""http:\/\/www[.]aywas[.]com\/breedcp\/index\/breedings/details\/\?id=(\d+)""");
            AddNewIds(regex.Matches(text).Cast<Match>().Select(m => m.Groups[1].Value));
        }

        private void NewIdsGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers.HasFlag(Keys.Control) && e.KeyCode == Keys.V)
            {
                ParseNewIds(Clipboard.GetText());
            }
        }

        private void NewIdsGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            newIdsGridView[e.ColumnIndex, e.RowIndex].ReadOnly = e.RowIndex != newIdsGridView.NewRowIndex && e.ColumnIndex == newIdColumn.Index;
        }

        private void NewIdsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // ignore out of range
            if (e.RowIndex < 0 || e.RowIndex >= newIdsGridView.RowCount) return;

            Breeding breeding = (Breeding)newIdsGridView.Rows[e.RowIndex].DataBoundItem;

            try
            {
                // update the breeding in the db
                breedings.Upsert(breeding);
                database.Checkpoint();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }

            // update the grid regardless
            FillGrid();             
        }

        private void NewUserPredictionsButton_Click(object sender, EventArgs e)
        {
            using (UserPredictionsForm dialog = new UserPredictionsForm())
            {
                if (dialog.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    database.BeginTrans();

                    foreach (Breeding breeding in dialog.Breedings)
                    {
                        // just skipping duplicte IDs
                        if (breedings.Exists(b => b.Id == breeding.Id)) continue;

                        // user predictions each have a unique batch
                        breeding.Batch = new Batch();

                        breeding.RollMutant();
                        breeding.RollRare();
                        breeding.RollXaoc();
                        breeding.Artist = Artist.UserArtist;

                        batches.Insert(breeding.Batch);
                        breedings.Insert(breeding);
                    }

                    database.Commit();
                    database.Checkpoint();
                    FillGrid();
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                    database.Rollback();
                }
            }
        }

        private void ManageArtistsButton_Click(object sender, EventArgs e)
        {
            using (ArtistsForm dialog = new ArtistsForm())
            {
                // give it all the artists
                dialog.Artists = artists.Query().ToList();

                // check for OK
                if (dialog.ShowDialog(this) != DialogResult.OK) return;

                // safely write the changes
                database.BeginTrans();
                try
                {
                    // upsert is cool
                    artists.Upsert(dialog.Artists);
                    database.Commit();
                    database.Checkpoint();
                    FillGrid();
                } 
                catch (Exception ex)
                {
                    HandleException(ex);
                    database.Rollback();
                }
            }
        }

        private void BreedingGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox control)
            {
                control.DataSource = artists.Query().Where(a => a.IsActive && a.Id != Artist.UserArtist.Id).ToList();
            }
        }

        private void BreedingGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || breedingGridView.RowCount <= e.RowIndex) return;

            if (e.ColumnIndex == artistColumn.Index)
            {
                Breeding breeding = GetBreedingFromGrid(breedingGridView.CurrentRow.Index);
                breeding.Artist = (Artist)((ComboBox)breedingGridView.EditingControl).SelectedItem;

                database.BeginTrans();
                try
                {
                    breedings.Update(breeding);
                    database.Commit();
                    database.Checkpoint();
                    FillGrid();
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                    database.Rollback();
                }
            }
        }

        private void AssignDropDownButton_DropDownOpening(object sender, EventArgs e)
        {
            assignDropDownButton.DropDownItems.Clear();
            assignDropDownButton.DropDownItems.AddRange(artists.Query().Where(a => a.IsActive && a.Id != Artist.UserArtist.Id).ToEnumerable().Select(a => new ToolStripButton() { Text = a.Name, Tag = a.Id }).ToArray());
            assignDropDownButton.DropDown.PerformLayout();
        }

        private void AssignDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Artist assign = artists.FindById((Guid)e.ClickedItem.Tag);
            IEnumerable<Breeding> selected = breedingGridView.SelectedRows.Cast<DataGridViewRow>().Select(r => (Breeding)r.DataBoundItem);
            foreach (Breeding breeding in selected)
            {
                breeding.Artist = assign;
            }
            database.BeginTrans();
            try
            {
                breedings.Update(selected);
                database.Commit();
                database.Checkpoint();
                FillGrid();
            }
            catch (Exception ex)
            {
                HandleException(ex);
                database.Rollback();
            }
        }
    }
}
