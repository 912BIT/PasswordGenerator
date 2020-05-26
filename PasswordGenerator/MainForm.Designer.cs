namespace PasswordGenerator
{
    partial class MainForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkbxLetters = new System.Windows.Forms.CheckBox();
            this.chkbxNumbers = new System.Windows.Forms.CheckBox();
            this.chkbxSpecial = new System.Windows.Forms.CheckBox();
            this.chkbxUpper = new System.Windows.Forms.CheckBox();
            this.chkbxLower = new System.Windows.Forms.CheckBox();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbxDefault = new System.Windows.Forms.CheckBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPasswords = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 439);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(612, 58);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkbxLetters
            // 
            this.chkbxLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbxLetters.AutoSize = true;
            this.chkbxLetters.Location = new System.Drawing.Point(79, 260);
            this.chkbxLetters.Name = "chkbxLetters";
            this.chkbxLetters.Size = new System.Drawing.Size(60, 17);
            this.chkbxLetters.TabIndex = 2;
            this.chkbxLetters.Text = "Letters";
            this.chkbxLetters.UseVisualStyleBackColor = true;
            this.chkbxLetters.CheckStateChanged += new System.EventHandler(this.chkbxLetters_CheckStateChanged);
            // 
            // chkbxNumbers
            // 
            this.chkbxNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbxNumbers.AutoSize = true;
            this.chkbxNumbers.Location = new System.Drawing.Point(304, 260);
            this.chkbxNumbers.Name = "chkbxNumbers";
            this.chkbxNumbers.Size = new System.Drawing.Size(68, 17);
            this.chkbxNumbers.TabIndex = 3;
            this.chkbxNumbers.Text = "Numbers";
            this.chkbxNumbers.UseVisualStyleBackColor = true;
            // 
            // chkbxSpecial
            // 
            this.chkbxSpecial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbxSpecial.AutoSize = true;
            this.chkbxSpecial.Location = new System.Drawing.Point(185, 260);
            this.chkbxSpecial.Name = "chkbxSpecial";
            this.chkbxSpecial.Size = new System.Drawing.Size(113, 17);
            this.chkbxSpecial.TabIndex = 4;
            this.chkbxSpecial.Text = "Special characters";
            this.chkbxSpecial.UseVisualStyleBackColor = true;
            // 
            // chkbxUpper
            // 
            this.chkbxUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbxUpper.AutoSize = true;
            this.chkbxUpper.Location = new System.Drawing.Point(99, 283);
            this.chkbxUpper.Name = "chkbxUpper";
            this.chkbxUpper.Size = new System.Drawing.Size(80, 17);
            this.chkbxUpper.TabIndex = 5;
            this.chkbxUpper.Text = "Upper case";
            this.chkbxUpper.UseVisualStyleBackColor = true;
            // 
            // chkbxLower
            // 
            this.chkbxLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbxLower.AutoSize = true;
            this.chkbxLower.Location = new System.Drawing.Point(99, 306);
            this.chkbxLower.Name = "chkbxLower";
            this.chkbxLower.Size = new System.Drawing.Size(80, 17);
            this.chkbxLower.TabIndex = 6;
            this.chkbxLower.Text = "Lower case";
            this.chkbxLower.UseVisualStyleBackColor = true;
            // 
            // nudLength
            // 
            this.nudLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudLength.Location = new System.Drawing.Point(12, 336);
            this.nudLength.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(80, 21);
            this.nudLength.TabIndex = 7;
            this.nudLength.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(98, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Length";
            // 
            // chkbxDefault
            // 
            this.chkbxDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbxDefault.AutoSize = true;
            this.chkbxDefault.Checked = true;
            this.chkbxDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxDefault.Location = new System.Drawing.Point(12, 260);
            this.chkbxDefault.Name = "chkbxDefault";
            this.chkbxDefault.Size = new System.Drawing.Size(61, 17);
            this.chkbxDefault.TabIndex = 9;
            this.chkbxDefault.Text = "Default";
            this.chkbxDefault.UseVisualStyleBackColor = true;
            this.chkbxDefault.CheckStateChanged += new System.EventHandler(this.chkbxDefault_CheckStateChanged);
            // 
            // nudCount
            // 
            this.nudCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudCount.Location = new System.Drawing.Point(12, 374);
            this.nudCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(80, 21);
            this.nudCount.TabIndex = 10;
            this.nudCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(98, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Count";
            // 
            // txbPasswords
            // 
            this.txbPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPasswords.Location = new System.Drawing.Point(12, 12);
            this.txbPasswords.MaxLength = 3100000;
            this.txbPasswords.Name = "txbPasswords";
            this.txbPasswords.Size = new System.Drawing.Size(612, 242);
            this.txbPasswords.TabIndex = 12;
            this.txbPasswords.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 509);
            this.Controls.Add(this.txbPasswords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.chkbxDefault);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.chkbxLower);
            this.Controls.Add(this.chkbxUpper);
            this.Controls.Add(this.chkbxSpecial);
            this.Controls.Add(this.chkbxNumbers);
            this.Controls.Add(this.chkbxLetters);
            this.Controls.Add(this.btnGenerate);
            this.MinimumSize = new System.Drawing.Size(407, 453);
            this.Name = "MainForm";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkbxLetters;
        private System.Windows.Forms.CheckBox chkbxNumbers;
        private System.Windows.Forms.CheckBox chkbxSpecial;
        private System.Windows.Forms.CheckBox chkbxUpper;
        private System.Windows.Forms.CheckBox chkbxLower;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkbxDefault;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txbPasswords;
    }
}

