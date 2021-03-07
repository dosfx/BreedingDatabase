using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            breedingBindingSource.DataSource = breedings.Query().ToList();
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

        private void NewBatchButton_Click(object sender, EventArgs e)
        {
            using (NewBatchForm dialog = new NewBatchForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Batch batch = new Batch();
                    batches.Insert(batch);
                    IList<Breeding> newBreedings = dialog.Breedings;
                    foreach (Breeding breeding in newBreedings)
                    {
                        breeding.Batch = batch;
                    }

                    breedings.Insert(newBreedings);

                    breedingBindingSource.DataSource = breedings.Query().ToList();
                }
            }
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
            return GetBreedingFromGrid(index).Batch.Id.Equals(GetBreedingFromGrid(index - 1).Batch.Id);
        }

        private void BreedingGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // get the breeding for this row or bail
            Breeding breeding = GetBreedingFromGrid(e.RowIndex);
            if (breeding == null) return;

            // handle the columns
            if (e.ColumnIndex == isMutantColumn.Index)
            {
                e.CellStyle.BackColor = ColorTranslator.FromHtml(breeding.IsMutant ? "#edff97" : "#d9d9d9");
                e.Value = breeding.IsMutant ? "Mutant" : "Metal";
            }
            else if (e.ColumnIndex == isRareColumn.Index)
            {
                if (breeding.IsMutant)
                {
                    e.Value = string.Empty;
                }
                else
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml(breeding.IsRare ? "#b7e1cd" : "#f7c7c3");
                    e.Value = breeding.IsRare ? "yes" : "no";
                }
            }
            else if (e.ColumnIndex == isHybridColumn.Index)
            {
                if (breeding.IsMutant)
                {
                    e.Value = string.Empty;
                }
                else
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml(breeding.IsHybrid ? "#fce8b2" : "#cfe2f3");
                    e.Value = breeding.IsHybrid ? "hybrid" : "C/UC";
                }
            }
            else if (e.ColumnIndex == batchColumn.Index)
            {
                e.Value = IsRepeatedBatchRow(e.RowIndex) ? string.Empty : breeding.Batch.BatchDate.ToString("D");
                breedingGridView[e.ColumnIndex, e.RowIndex].ToolTipText = breeding.Batch.BatchDate.ToString("F");
            }
        }

        private void BreedingGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
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
                    breeding.Batch.Id.Equals(((Breeding)breedingBindingSource[e.RowIndex + 1]).Batch.Id))
                {
                    e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
                }
            }
        }

        private void BreedingGridView_SelectionChanged(object sender, EventArgs e)
        {
            breedingGridView.ClearSelection();
        }
    }
}
