using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace BreedingDatabase
{
    public partial class MainForm : Form
    {
        private readonly ILiteDatabase database;
        private readonly ILiteCollection<Batch> batches;
        private readonly ILiteCollection<Breeding> breedings;

        private bool IsCreateBatchEnabled
        {
            get
            {
                int selectedCount = breedingGridView.SelectedRows.Count;

                // simple check, are there 5 10 or 20 selected rows
                if (!(new int[] { 5, 10, 20 }).Contains(selectedCount)) return false;

                // find the index of the last unbatched row
                int index = 0;
                for (; index < breedingGridView.RowCount; index++)
                {
                    if (GetBreedingFromGrid(index).Batch != null)
                    {
                        // first batched row, go up 1
                        index--;
                        break;
                    }
                }

                // no unbatched rows in this case
                if (index < 0) return false;

                HashSet<int> requiredIndexes = new HashSet<int>(Enumerable.Range(index - selectedCount + 1, selectedCount));
                return requiredIndexes.SetEquals(breedingGridView.SelectedRows.Cast<DataGridViewRow>().Select(r => r.Index));
            }
        }

        public MainForm()
        {
            InitializeComponent();

            database = new LiteDatabase("breeding.db");
            batches = database.GetCollection<Batch>();
            breedings = database.GetCollection<Breeding>();
            //database.Execute("select $ into $file('breeding.json') from Breeding");
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
        }

        private void FillGrid()
        {
            breedingBindingSource.DataSource = Enumerable.Concat(
                breedings.Query().Where(b => b.Batch == null).OrderByDescending(b => b.Id).ToEnumerable(),
                breedings.Query().Where(b => b.Batch != null).Include(b => b.Batch).ToEnumerable().OrderByDescending(b => b.Batch.BatchDate).ThenBy(b => b.Ordering));
        }

        private void AddBreedingsButton_Click(object sender, EventArgs e)
        {
            using (AddBreedingsForm dialog = new AddBreedingsForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try 
                    {
                        database.BeginTrans();
                        IList<Breeding> newBreedings = dialog.Breedings;
                        foreach (Breeding breeding in newBreedings)
                        {
                            // check if ID exists
                            if (breedings.FindById(breeding.Id) == null)
                            {
                                breedings.Insert(breeding);
                            }
                        }

                        database.Commit();
                        database.Checkpoint();
                    }
                    catch (Exception ex)
                    {
                        database.Rollback();
                        HandleException(ex);
                    }

                    FillGrid();
                }
            }
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
            if (MessageBox.Show("Do you want to create a new batch with the selected breedings?", "Create Batch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                database.BeginTrans();
                Batch batch = new Batch();
                batches.Insert(batch);
                List<Breeding> batchBreedings = breedingGridView.SelectedRows.Cast<DataGridViewRow>().Select(r => GetBreedingFromGrid(r.Index)).ToList();
                foreach (Breeding breeding in batchBreedings)
                {
                    // calc the hash to sort the breedings by
                    breeding.CalcOrdering();
                    breeding.BreedingType = BreedingType.Mutant;
                    breeding.Batch = batch;
                }

                // sort according to the hash
                batchBreedings.Sort((a, b) => a.Ordering.CompareTo(b.Ordering));

                // every 5 is special
                for (int i = 4; i < batchBreedings.Count; i += 5)
                {
                    Breeding special = batchBreedings[i];
                    special.RollRare();
                    special.SetTypeFromIndex(i);
                }

                // fix the 5 batch to roll type
                if (batchBreedings.Count == 5)
                {
                    Breeding special = batchBreedings[4];
                    special.RollBreedingType();
                }

                breedings.Update(batchBreedings);

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

        private void BreedingGridView_SelectionChanged(object sender, EventArgs e)
        {
            createBatchButton.Enabled = IsCreateBatchEnabled;
        }
    }
}
