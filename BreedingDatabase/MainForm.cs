using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        public MainForm()
        {
            InitializeComponent();

            database = new LiteDatabase("breeding.db");
            batches = database.GetCollection<Batch>();
            breedings = database.GetCollection<Breeding>();
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
                breedings.Query().Where(b => b.Batch == null).OrderBy(b => b.Id).ToEnumerable(), 
                breedings.Query().Where(b => b.Batch != null).OrderBy(b => b.Ordering).ToEnumerable().OrderBy(b => b.Batch.BatchDate.Ticks));
        }

        private void NewBatchButton_Click(object sender, EventArgs e)
        {
            using (NewBatchForm dialog = new NewBatchForm())
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
            try
            {
                database.BeginTrans();
                Batch batch = new Batch();
                batches.Insert(batch);
                List<Breeding> batchBreedings = breedingGridView.SelectedRows.Cast<DataGridViewRow>().Select(r => GetBreedingFromGrid(r.Index)).ToList();
                foreach (Breeding breeding in batchBreedings)
                {
                    // calc the hash to sort the breedings by
                    breeding.Ordering = ToHexString(Hash(breeding));
                    breeding.BreedingType = BreedingType.Mutant;
                    breeding.Batch = batch;
                }

                // sort according to the hash
                batchBreedings.Sort((a, b) => a.Ordering.CompareTo(b.Ordering));

                // every 5 is special
                for (int i = 4; i < batchBreedings.Count; i += 5)
                {
                    Breeding special = batchBreedings[i];
                    special.IsRare = Chance(special, 4, 1);
                    special.BreedingType = i % 10 == 4 ? BreedingType.Hybrid : BreedingType.CommonUncommon;
                }

                // fix the 5 batch to roll type
                if (batchBreedings.Count == 5)
                {
                    Breeding special = batchBreedings[4];
                    special.BreedingType = Chance(special, 2, 2) ? BreedingType.Hybrid : BreedingType.CommonUncommon;
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

        private byte[] Hash(Breeding breeding, int extraHashes = 0)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(Convert.ToBase64String(Encoding.UTF8.GetBytes(breeding.Id.ToString())));
            using (SHA512 sha = SHA512.Create())
            {
                do
                {
                    bytes = sha.ComputeHash(bytes);
                    extraHashes--;
                } while (extraHashes >= 0);
            }

            return bytes;
        }

        private bool Chance(Breeding breeding, int odds, int index)
        {
            return Hash(breeding, index)[0] % odds == 0;
        }

        private string ToHexString(byte[] bytes)
        {
            StringBuilder builder = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                builder.AppendFormat("{0:x2}", b);
            }
            return builder.ToString();
        }

        private void BreedingGridView_SelectionChanged(object sender, EventArgs e)
        {
            createBatchButton.Enabled = (new int[] { 5, 10, 20 }).Contains(breedingGridView.SelectedRows.Count) &&
                breedingGridView.SelectedRows.Cast<DataGridViewRow>().All(r => GetBreedingFromGrid(r.Index).Batch == null);
        }
    }
}
