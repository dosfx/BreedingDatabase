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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addBreedingsButton = new System.Windows.Forms.ToolStripButton();
            this.createBatchButton = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedingTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.breedingGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breedingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // breedingGridView
            // 
            this.breedingGridView.AllowUserToAddRows = false;
            this.breedingGridView.AllowUserToDeleteRows = false;
            this.breedingGridView.AllowUserToResizeRows = false;
            this.breedingGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.breedingGridView.AutoGenerateColumns = false;
            this.breedingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breedingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchColumn,
            this.breedingTypeColumn,
            this.idColumn,
            this.isRareColumn,
            this.Ordering});
            this.breedingGridView.DataSource = this.breedingBindingSource;
            this.breedingGridView.Location = new System.Drawing.Point(0, 28);
            this.breedingGridView.Name = "breedingGridView";
            this.breedingGridView.ReadOnly = true;
            this.breedingGridView.RowHeadersVisible = false;
            this.breedingGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.breedingGridView.Size = new System.Drawing.Size(800, 422);
            this.breedingGridView.TabIndex = 0;
            this.breedingGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.BreedingGridView_CellFormatting);
            this.breedingGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.BreedingGridView_CellPainting);
            this.breedingGridView.SelectionChanged += new System.EventHandler(this.BreedingGridView_SelectionChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBreedingsButton,
            this.createBatchButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(4, 3, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addBreedingsButton
            // 
            this.addBreedingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBreedingsButton.Name = "addBreedingsButton";
            this.addBreedingsButton.Size = new System.Drawing.Size(97, 19);
            this.addBreedingsButton.Text = "Add Breedings...";
            this.addBreedingsButton.Click += new System.EventHandler(this.AddBreedingsButton_Click);
            // 
            // createBatchButton
            // 
            this.createBatchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createBatchButton.Name = "createBatchButton";
            this.createBatchButton.Size = new System.Drawing.Size(78, 19);
            this.createBatchButton.Text = "Create Batch";
            this.createBatchButton.Click += new System.EventHandler(this.CreateBatchButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BreedingType";
            this.dataGridViewTextBoxColumn1.HeaderText = "Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // breedingBindingSource
            // 
            this.breedingBindingSource.DataSource = typeof(BreedingDatabase.Breeding);
            // 
            // batchColumn
            // 
            this.batchColumn.DataPropertyName = "Batch";
            this.batchColumn.HeaderText = "Batch";
            this.batchColumn.Name = "batchColumn";
            this.batchColumn.ReadOnly = true;
            // 
            // breedingTypeColumn
            // 
            this.breedingTypeColumn.DataPropertyName = "BreedingType";
            this.breedingTypeColumn.HeaderText = "Type";
            this.breedingTypeColumn.Name = "breedingTypeColumn";
            this.breedingTypeColumn.ReadOnly = true;
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
            // Ordering
            // 
            this.Ordering.DataPropertyName = "Ordering";
            this.Ordering.HeaderText = "Ordering";
            this.Ordering.Name = "Ordering";
            this.Ordering.ReadOnly = true;
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
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breedingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView breedingGridView;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.BindingSource breedingBindingSource;
        private System.Windows.Forms.ToolStripButton addBreedingsButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton createBatchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedingTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRareColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordering;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

