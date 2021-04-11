
namespace BreedingDatabase
{
    partial class ArtistsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.artistGridView = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.isActiveColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.artistGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // artistGridView
            // 
            this.artistGridView.AllowUserToDeleteRows = false;
            this.artistGridView.AutoGenerateColumns = false;
            this.artistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artistGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isActiveColumn,
            this.nameColumn});
            this.artistGridView.DataSource = this.artistBindingSource;
            this.artistGridView.Location = new System.Drawing.Point(12, 12);
            this.artistGridView.Name = "artistGridView";
            this.artistGridView.RowHeadersVisible = false;
            this.artistGridView.Size = new System.Drawing.Size(776, 397);
            this.artistGridView.TabIndex = 0;
            this.artistGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArtistGridView_CellEnter);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(713, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(632, 415);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // isActiveColumn
            // 
            this.isActiveColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isActiveColumn.DataPropertyName = "IsActive";
            this.isActiveColumn.HeaderText = "Active";
            this.isActiveColumn.Name = "isActiveColumn";
            this.isActiveColumn.Width = 43;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // artistBindingSource
            // 
            this.artistBindingSource.DataSource = typeof(BreedingDatabase.Artist);
            // 
            // ArtistsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.artistGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArtistsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Artists";
            ((System.ComponentModel.ISupportInitialize)(this.artistGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView artistGridView;
        private System.Windows.Forms.BindingSource artistBindingSource;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
    }
}