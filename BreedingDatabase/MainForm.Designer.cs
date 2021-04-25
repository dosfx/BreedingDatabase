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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.breedingGridView = new System.Windows.Forms.DataGridView();
            this.batchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedingTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolledXaocColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ordering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newUserPredictionsButton = new System.Windows.Forms.ToolStripButton();
            this.manageArtistsButton = new System.Windows.Forms.ToolStripButton();
            this.assignDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.createBatchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newIdsGridView = new System.Windows.Forms.DataGridView();
            this.newIdColumn = new BreedingDatabase.DataGridViewIdColumn();
            this.newIsMoozeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.newIsXaocColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.breedingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breedingBindingSource)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newIdsGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.rolledXaocColumn,
            this.artistColumn,
            this.Ordering});
            this.breedingGridView.DataSource = this.breedingBindingSource;
            this.breedingGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breedingGridView.Location = new System.Drawing.Point(3, 16);
            this.breedingGridView.Name = "breedingGridView";
            this.breedingGridView.RowHeadersVisible = false;
            this.breedingGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.breedingGridView.Size = new System.Drawing.Size(461, 391);
            this.breedingGridView.TabIndex = 0;
            this.breedingGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.BreedingGridView_CellFormatting);
            this.breedingGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.BreedingGridView_CellPainting);
            this.breedingGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BreedingGridView_CellValueChanged);
            this.breedingGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.BreedingGridView_EditingControlShowing);
            // 
            // batchColumn
            // 
            this.batchColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.batchColumn.DataPropertyName = "Batch";
            this.batchColumn.HeaderText = "Batch";
            this.batchColumn.Name = "batchColumn";
            this.batchColumn.ReadOnly = true;
            this.batchColumn.Width = 60;
            // 
            // breedingTypeColumn
            // 
            this.breedingTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.breedingTypeColumn.DataPropertyName = "BreedingType";
            this.breedingTypeColumn.HeaderText = "Type";
            this.breedingTypeColumn.Name = "breedingTypeColumn";
            this.breedingTypeColumn.ReadOnly = true;
            this.breedingTypeColumn.Width = 56;
            // 
            // idColumn
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 43;
            // 
            // isRareColumn
            // 
            this.isRareColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isRareColumn.DataPropertyName = "IsRare";
            this.isRareColumn.HeaderText = "Rare?";
            this.isRareColumn.Name = "isRareColumn";
            this.isRareColumn.ReadOnly = true;
            this.isRareColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isRareColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.isRareColumn.Width = 42;
            // 
            // rolledXaocColumn
            // 
            this.rolledXaocColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rolledXaocColumn.DataPropertyName = "RolledXaoc";
            this.rolledXaocColumn.HeaderText = "Xaoc?";
            this.rolledXaocColumn.Name = "rolledXaocColumn";
            this.rolledXaocColumn.ReadOnly = true;
            this.rolledXaocColumn.Width = 63;
            // 
            // artistColumn
            // 
            this.artistColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artistColumn.DataPropertyName = "ArtistId";
            this.artistColumn.DataSource = this.artistBindingSource;
            this.artistColumn.DisplayMember = "Name";
            this.artistColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.artistColumn.HeaderText = "Artist";
            this.artistColumn.Name = "artistColumn";
            this.artistColumn.ValueMember = "Id";
            // 
            // artistBindingSource
            // 
            this.artistBindingSource.DataSource = typeof(BreedingDatabase.Artist);
            // 
            // Ordering
            // 
            this.Ordering.DataPropertyName = "Ordering";
            this.Ordering.HeaderText = "Ordering";
            this.Ordering.Name = "Ordering";
            this.Ordering.ReadOnly = true;
            this.Ordering.Visible = false;
            // 
            // breedingBindingSource
            // 
            this.breedingBindingSource.DataSource = typeof(BreedingDatabase.Breeding);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserPredictionsButton,
            this.manageArtistsButton,
            this.assignDropDownButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(4, 3, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // newUserPredictionsButton
            // 
            this.newUserPredictionsButton.Name = "newUserPredictionsButton";
            this.newUserPredictionsButton.Size = new System.Drawing.Size(132, 19);
            this.newUserPredictionsButton.Text = "New User Predictions...";
            this.newUserPredictionsButton.Click += new System.EventHandler(this.NewUserPredictionsButton_Click);
            // 
            // manageArtistsButton
            // 
            this.manageArtistsButton.Name = "manageArtistsButton";
            this.manageArtistsButton.Size = new System.Drawing.Size(99, 19);
            this.manageArtistsButton.Text = "Manage Artists...";
            this.manageArtistsButton.Click += new System.EventHandler(this.ManageArtistsButton_Click);
            // 
            // assignDropDownButton
            // 
            this.assignDropDownButton.Name = "assignDropDownButton";
            this.assignDropDownButton.ShowDropDownArrow = false;
            this.assignDropDownButton.Size = new System.Drawing.Size(171, 19);
            this.assignDropDownButton.Text = "Assign Selected Breedings to...";
            this.assignDropDownButton.DropDownOpening += new System.EventHandler(this.AssignDropDownButton_DropDownOpening);
            this.assignDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.AssignDropDownButton_DropDownItemClicked);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.newIdsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            // newIdColumn
            // 
            this.newIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newIdColumn.DataPropertyName = "Id";
            this.newIdColumn.HeaderText = "ID";
            this.newIdColumn.Name = "newIdColumn";
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
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Artist";
            this.dataGridViewComboBoxColumn1.HeaderText = "Artist";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BreedingType";
            this.dataGridViewTextBoxColumn1.HeaderText = "Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BreedingType";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ordering";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ordering";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Breeding Database";
            ((System.ComponentModel.ISupportInitialize)(this.breedingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breedingBindingSource)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newIdsGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView newIdsGridView;
        private BreedingDatabase.DataGridViewIdColumn newIdColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn newIsMoozeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn newIsXaocColumn;
        private System.Windows.Forms.ToolStripButton newUserPredictionsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton manageArtistsButton;
        private System.Windows.Forms.BindingSource artistBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.ToolStripDropDownButton assignDropDownButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedingTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRareColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolledXaocColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn artistColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordering;
    }
}

