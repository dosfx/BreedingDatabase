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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.breedingGridView = new System.Windows.Forms.DataGridView();
            this.Ordering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createBatchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newIdsGridView = new System.Windows.Forms.DataGridView();
            this.newIsMoozeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.newIsXaocColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedingTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newIdColumn = new BreedingDatabase.DataGridViewIdColumn();
            ((System.ComponentModel.ISupportInitialize)(this.breedingGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newIdsGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breedingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // breedingGridView
            // 
            this.breedingGridView.AllowUserToAddRows = false;
            this.breedingGridView.AllowUserToDeleteRows = false;
            this.breedingGridView.AllowUserToResizeRows = false;
            this.breedingGridView.AutoGenerateColumns = false;
            this.breedingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breedingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchColumn,
            this.breedingTypeColumn,
            this.idColumn,
            this.isRareColumn,
            this.Ordering});
            this.breedingGridView.DataSource = this.breedingBindingSource;
            this.breedingGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breedingGridView.Location = new System.Drawing.Point(3, 16);
            this.breedingGridView.Name = "breedingGridView";
            this.breedingGridView.ReadOnly = true;
            this.breedingGridView.RowHeadersVisible = false;
            this.breedingGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.breedingGridView.Size = new System.Drawing.Size(461, 391);
            this.breedingGridView.TabIndex = 0;
            this.breedingGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.BreedingGridView_CellFormatting);
            this.breedingGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.BreedingGridView_CellPainting);
            // 
            // Ordering
            // 
            this.Ordering.DataPropertyName = "Ordering";
            this.Ordering.HeaderText = "Ordering";
            this.Ordering.Name = "Ordering";
            this.Ordering.ReadOnly = true;
            this.Ordering.Visible = false;
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(4, 3, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BreedingType";
            this.dataGridViewTextBoxColumn1.HeaderText = "Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // createBatchButton
            // 
            this.createBatchButton.Location = new System.Drawing.Point(240, 80);
            this.createBatchButton.Name = "createBatchButton";
            this.createBatchButton.Size = new System.Drawing.Size(75, 80);
            this.createBatchButton.TabIndex = 3;
            this.createBatchButton.Text = ">>>\r\nCreate\r\nBatch\r\n>>>";
            this.createBatchButton.UseVisualStyleBackColor = true;
            this.createBatchButton.Click += new System.EventHandler(this.CreateBatchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.newIdsGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 410);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Un-batched";
            // 
            // newIdsGridView
            // 
            this.newIdsGridView.AllowUserToResizeColumns = false;
            this.newIdsGridView.AllowUserToResizeRows = false;
            this.newIdsGridView.AutoGenerateColumns = false;
            this.newIdsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.newIdsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.newIdsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newIdsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.newIdColumn,
            this.newIsMoozeColumn,
            this.newIsXaocColumn});
            this.newIdsGridView.DataSource = this.breedingBindingSource;
            this.newIdsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newIdsGridView.Location = new System.Drawing.Point(3, 16);
            this.newIdsGridView.Name = "newIdsGridView";
            this.newIdsGridView.RowHeadersVisible = false;
            this.newIdsGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.newIdsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.newIdsGridView.Size = new System.Drawing.Size(216, 391);
            this.newIdsGridView.TabIndex = 4;
            this.newIdsGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewIdsGridView_CellEnter);
            this.newIdsGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewIdsGridView_CellValueChanged);
            this.newIdsGridView.SelectionChanged += new System.EventHandler(this.NewIdsGridView_SelectionChanged);
            this.newIdsGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NewIdsGridView_KeyUp);
            // 
            // newIsMoozeColumn
            // 
            this.newIsMoozeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.newIsMoozeColumn.DataPropertyName = "IsMooze";
            this.newIsMoozeColumn.HeaderText = "M.O.";
            this.newIsMoozeColumn.Name = "newIsMoozeColumn";
            this.newIsMoozeColumn.ToolTipText = "Mutagenic Ooze";
            this.newIsMoozeColumn.Width = 36;
            // 
            // newIsXaocColumn
            // 
            this.newIsXaocColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.newIsXaocColumn.DataPropertyName = "IsXaoc";
            this.newIsXaocColumn.HeaderText = "Xaoc?";
            this.newIsXaocColumn.Name = "newIsXaocColumn";
            this.newIsXaocColumn.Width = 44;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.breedingGridView);
            this.groupBox2.Location = new System.Drawing.Point(321, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 410);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rolled and Batched";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BreedingType";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // breedingBindingSource
            // 
            this.breedingBindingSource.DataSource = typeof(BreedingDatabase.Breeding);
            // 
            // newIdColumn
            // 
            this.newIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newIdColumn.DataPropertyName = "Id";
            this.newIdColumn.HeaderText = "ID";
            this.newIdColumn.Name = "newIdColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createBatchButton);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.Text = "Breeding Database";
            ((System.ComponentModel.ISupportInitialize)(this.breedingGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newIdsGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.breedingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView breedingGridView;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.BindingSource breedingBindingSource;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button createBatchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedingTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRareColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordering;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView newIdsGridView;
        private BreedingDatabase.DataGridViewIdColumn newIdColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn newIsMoozeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn newIsXaocColumn;
    }
}

