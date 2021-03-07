namespace BreedingDatabase
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.breedingGridView = new System.Windows.Forms.DataGridView();
            this.batchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMutantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isHybridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newBatchButton = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.breedingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breedingBindingSource)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // breedingGridView
            // 
            this.breedingGridView.AllowUserToAddRows = false;
            this.breedingGridView.AllowUserToDeleteRows = false;
            this.breedingGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.breedingGridView.AutoGenerateColumns = false;
            this.breedingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breedingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchColumn,
            this.isMutantColumn,
            this.idColumn,
            this.isRareColumn,
            this.isHybridColumn});
            this.breedingGridView.DataSource = this.breedingBindingSource;
            this.breedingGridView.Location = new System.Drawing.Point(0, 28);
            this.breedingGridView.Name = "breedingGridView";
            this.breedingGridView.ReadOnly = true;
            this.breedingGridView.RowHeadersVisible = false;
            this.breedingGridView.Size = new System.Drawing.Size(800, 422);
            this.breedingGridView.TabIndex = 0;
            this.breedingGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.BreedingGridView_CellFormatting);
            this.breedingGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.BreedingGridView_CellPainting);
            this.breedingGridView.SelectionChanged += new System.EventHandler(this.BreedingGridView_SelectionChanged);
            // 
            // batchColumn
            // 
            this.batchColumn.DataPropertyName = "Batch";
            this.batchColumn.HeaderText = "Batch";
            this.batchColumn.Name = "batchColumn";
            this.batchColumn.ReadOnly = true;
            // 
            // isMutantColumn
            // 
            this.isMutantColumn.DataPropertyName = "IsMutant";
            this.isMutantColumn.HeaderText = "Type";
            this.isMutantColumn.Name = "isMutantColumn";
            this.isMutantColumn.ReadOnly = true;
            this.isMutantColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isMutantColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // isRareColumn
            // 
            this.isRareColumn.DataPropertyName = "IsRare";
            this.isRareColumn.HeaderText = "Rare?";
            this.isRareColumn.Name = "isRareColumn";
            this.isRareColumn.ReadOnly = true;
            this.isRareColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isRareColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // isHybridColumn
            // 
            this.isHybridColumn.DataPropertyName = "IsHybrid";
            this.isHybridColumn.HeaderText = "C/UC or H?";
            this.isHybridColumn.Name = "isHybridColumn";
            this.isHybridColumn.ReadOnly = true;
            this.isHybridColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isHybridColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // breedingBindingSource
            // 
            this.breedingBindingSource.DataSource = typeof(BreedingDatabase.Breeding);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBatchButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(4, 3, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // newBatchButton
            // 
            this.newBatchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newBatchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newBatchButton.Name = "newBatchButton";
            this.newBatchButton.Size = new System.Drawing.Size(77, 19);
            this.newBatchButton.Text = "New Batch...";
            this.newBatchButton.Click += new System.EventHandler(this.NewBatchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.breedingGridView);
            this.Name = "MainForm";
            this.Text = "Breeding Database";
            ((System.ComponentModel.ISupportInitialize)(this.breedingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breedingBindingSource)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView breedingGridView;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.BindingSource breedingBindingSource;
        private System.Windows.Forms.ToolStripButton newBatchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isMutantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRareColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isHybridColumn;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

