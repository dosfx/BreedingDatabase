
namespace BreedingDatabase
{
    partial class TestIdForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.invalidIdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xoacCheckBox = new System.Windows.Forms.CheckBox();
            this.ultraCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.typeResultLabel = new System.Windows.Forms.Label();
            this.rareResultLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.xaocResultLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ultraResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(185, 204);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(63, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(139, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.TextChanged += new System.EventHandler(this.InputControl_Changed);
            // 
            // invalidIdLabel
            // 
            this.invalidIdLabel.AutoSize = true;
            this.invalidIdLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidIdLabel.Location = new System.Drawing.Point(208, 15);
            this.invalidIdLabel.Name = "invalidIdLabel";
            this.invalidIdLabel.Size = new System.Drawing.Size(52, 13);
            this.invalidIdLabel.TabIndex = 2;
            this.invalidIdLabel.Text = "Invalid ID";
            this.invalidIdLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input ID";
            // 
            // xoacCheckBox
            // 
            this.xoacCheckBox.AutoSize = true;
            this.xoacCheckBox.Location = new System.Drawing.Point(15, 38);
            this.xoacCheckBox.Name = "xoacCheckBox";
            this.xoacCheckBox.Size = new System.Drawing.Size(57, 17);
            this.xoacCheckBox.TabIndex = 11;
            this.xoacCheckBox.Text = "Xaoc?";
            this.xoacCheckBox.UseVisualStyleBackColor = true;
            this.xoacCheckBox.CheckedChanged += new System.EventHandler(this.InputControl_Changed);
            // 
            // ultraCheckBox
            // 
            this.ultraCheckBox.AutoSize = true;
            this.ultraCheckBox.Location = new System.Drawing.Point(15, 61);
            this.ultraCheckBox.Name = "ultraCheckBox";
            this.ultraCheckBox.Size = new System.Drawing.Size(80, 17);
            this.ultraCheckBox.TabIndex = 12;
            this.ultraCheckBox.Text = "Ultra Rare?";
            this.ultraCheckBox.UseVisualStyleBackColor = true;
            this.ultraCheckBox.CheckedChanged += new System.EventHandler(this.InputControl_Changed);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 2);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Breeding Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rare?";
            // 
            // typeResultLabel
            // 
            this.typeResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeResultLabel.Location = new System.Drawing.Point(103, 89);
            this.typeResultLabel.Name = "typeResultLabel";
            this.typeResultLabel.Size = new System.Drawing.Size(60, 22);
            this.typeResultLabel.TabIndex = 15;
            this.typeResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rareResultLabel
            // 
            this.rareResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rareResultLabel.Location = new System.Drawing.Point(103, 115);
            this.rareResultLabel.Name = "rareResultLabel";
            this.rareResultLabel.Size = new System.Drawing.Size(60, 22);
            this.rareResultLabel.TabIndex = 17;
            this.rareResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Xaoc?";
            // 
            // xaocResultLabel
            // 
            this.xaocResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xaocResultLabel.Location = new System.Drawing.Point(103, 141);
            this.xaocResultLabel.Name = "xaocResultLabel";
            this.xaocResultLabel.Size = new System.Drawing.Size(60, 22);
            this.xaocResultLabel.TabIndex = 21;
            this.xaocResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ultra Rare?";
            // 
            // ultraResultLabel
            // 
            this.ultraResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ultraResultLabel.Location = new System.Drawing.Point(103, 167);
            this.ultraResultLabel.Name = "ultraResultLabel";
            this.ultraResultLabel.Size = new System.Drawing.Size(60, 22);
            this.ultraResultLabel.TabIndex = 23;
            this.ultraResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(272, 239);
            this.Controls.Add(this.ultraResultLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.xaocResultLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rareResultLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typeResultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ultraCheckBox);
            this.Controls.Add(this.xoacCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invalidIdLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.closeButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestIdForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestIdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label invalidIdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox xoacCheckBox;
        private System.Windows.Forms.CheckBox ultraCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label typeResultLabel;
        private System.Windows.Forms.Label rareResultLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label xaocResultLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ultraResultLabel;
    }
}