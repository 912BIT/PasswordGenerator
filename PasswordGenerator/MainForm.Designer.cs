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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkbxLetters = new System.Windows.Forms.CheckBox();
            this.chkbxNumbers = new System.Windows.Forms.CheckBox();
            this.chkbxSpecial = new System.Windows.Forms.CheckBox();
            this.chkbxUpper = new System.Windows.Forms.CheckBox();
            this.chkbxLower = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbxDefault = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(612, 304);
            this.textBox1.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 431);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(612, 66);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // chkbxLetters
            // 
            this.chkbxLetters.AutoSize = true;
            this.chkbxLetters.Location = new System.Drawing.Point(12, 356);
            this.chkbxLetters.Name = "chkbxLetters";
            this.chkbxLetters.Size = new System.Drawing.Size(60, 17);
            this.chkbxLetters.TabIndex = 2;
            this.chkbxLetters.Text = "Letters";
            this.chkbxLetters.UseVisualStyleBackColor = true;
            // 
            // chkbxNumbers
            // 
            this.chkbxNumbers.AutoSize = true;
            this.chkbxNumbers.Location = new System.Drawing.Point(78, 356);
            this.chkbxNumbers.Name = "chkbxNumbers";
            this.chkbxNumbers.Size = new System.Drawing.Size(68, 17);
            this.chkbxNumbers.TabIndex = 3;
            this.chkbxNumbers.Text = "Numbers";
            this.chkbxNumbers.UseVisualStyleBackColor = true;
            // 
            // chkbxSpecial
            // 
            this.chkbxSpecial.AutoSize = true;
            this.chkbxSpecial.Location = new System.Drawing.Point(152, 356);
            this.chkbxSpecial.Name = "chkbxSpecial";
            this.chkbxSpecial.Size = new System.Drawing.Size(113, 17);
            this.chkbxSpecial.TabIndex = 4;
            this.chkbxSpecial.Text = "Special characters";
            this.chkbxSpecial.UseVisualStyleBackColor = true;
            // 
            // chkbxUpper
            // 
            this.chkbxUpper.AutoSize = true;
            this.chkbxUpper.Location = new System.Drawing.Point(271, 356);
            this.chkbxUpper.Name = "chkbxUpper";
            this.chkbxUpper.Size = new System.Drawing.Size(80, 17);
            this.chkbxUpper.TabIndex = 5;
            this.chkbxUpper.Text = "Upper case";
            this.chkbxUpper.UseVisualStyleBackColor = true;
            // 
            // chkbxLower
            // 
            this.chkbxLower.AutoSize = true;
            this.chkbxLower.Location = new System.Drawing.Point(357, 356);
            this.chkbxLower.Name = "chkbxLower";
            this.chkbxLower.Size = new System.Drawing.Size(80, 17);
            this.chkbxLower.TabIndex = 6;
            this.chkbxLower.Text = "Lower case";
            this.chkbxLower.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 391);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 21);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(98, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Length";
            // 
            // chkbxDefault
            // 
            this.chkbxDefault.AutoSize = true;
            this.chkbxDefault.Checked = true;
            this.chkbxDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxDefault.Location = new System.Drawing.Point(12, 322);
            this.chkbxDefault.Name = "chkbxDefault";
            this.chkbxDefault.Size = new System.Drawing.Size(61, 17);
            this.chkbxDefault.TabIndex = 9;
            this.chkbxDefault.Text = "Default";
            this.chkbxDefault.UseVisualStyleBackColor = true;
            this.chkbxDefault.CheckStateChanged += new System.EventHandler(this.chkbxDefault_CheckStateChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 509);
            this.Controls.Add(this.chkbxDefault);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.chkbxLower);
            this.Controls.Add(this.chkbxUpper);
            this.Controls.Add(this.chkbxSpecial);
            this.Controls.Add(this.chkbxNumbers);
            this.Controls.Add(this.chkbxLetters);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkbxLetters;
        private System.Windows.Forms.CheckBox chkbxNumbers;
        private System.Windows.Forms.CheckBox chkbxSpecial;
        private System.Windows.Forms.CheckBox chkbxUpper;
        private System.Windows.Forms.CheckBox chkbxLower;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkbxDefault;
    }
}

