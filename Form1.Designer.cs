namespace pwdgen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbLength = new System.Windows.Forms.ComboBox();
            this.chkBracket = new System.Windows.Forms.CheckBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.chkSpace = new System.Windows.Forms.CheckBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.chkNum = new System.Windows.Forms.CheckBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbLength);
            this.panel1.Controls.Add(this.chkBracket);
            this.panel1.Controls.Add(this.chkSpecial);
            this.panel1.Controls.Add(this.chkSpace);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.chkNum);
            this.panel1.Controls.Add(this.chkUpper);
            this.panel1.Controls.Add(this.chkLower);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 129);
            this.panel1.TabIndex = 0;
            // 
            // cmbLength
            // 
            this.cmbLength.FormattingEnabled = true;
            this.cmbLength.Location = new System.Drawing.Point(230, 17);
            this.cmbLength.Name = "cmbLength";
            this.cmbLength.Size = new System.Drawing.Size(73, 21);
            this.cmbLength.TabIndex = 8;
            // 
            // chkBracket
            // 
            this.chkBracket.AutoSize = true;
            this.chkBracket.Location = new System.Drawing.Point(177, 100);
            this.chkBracket.Name = "chkBracket";
            this.chkBracket.Size = new System.Drawing.Size(88, 17);
            this.chkBracket.TabIndex = 7;
            this.chkBracket.Text = "Brackets [],{}";
            this.chkBracket.UseVisualStyleBackColor = true;
            this.chkBracket.CheckedChanged += new System.EventHandler(this.chkBracket_CheckedChanged);
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(177, 77);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(151, 17);
            this.chkSpecial.TabIndex = 6;
            this.chkSpecial.Text = "Special Characters[ !,@,#]";
            this.chkSpecial.UseVisualStyleBackColor = true;
            this.chkSpecial.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkSpace
            // 
            this.chkSpace.AutoSize = true;
            this.chkSpace.Location = new System.Drawing.Point(177, 53);
            this.chkSpace.Name = "chkSpace";
            this.chkSpace.Size = new System.Drawing.Size(117, 17);
            this.chkSpace.TabIndex = 5;
            this.chkSpace.Text = "Space character [ ]";
            this.chkSpace.UseVisualStyleBackColor = true;
            this.chkSpace.CheckedChanged += new System.EventHandler(this.chkSpace_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(76, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(146, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Choose the Password Length";
            // 
            // chkNum
            // 
            this.chkNum.AutoSize = true;
            this.chkNum.Location = new System.Drawing.Point(7, 94);
            this.chkNum.Name = "chkNum";
            this.chkNum.Size = new System.Drawing.Size(95, 17);
            this.chkNum.TabIndex = 2;
            this.chkNum.Text = "Numbers [0..9]";
            this.chkNum.UseVisualStyleBackColor = true;
            this.chkNum.CheckedChanged += new System.EventHandler(this.chkNum_CheckedChanged);
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(7, 71);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(127, 17);
            this.chkUpper.TabIndex = 1;
            this.chkUpper.Text = "Alpha (Upper) [A,B,C]";
            this.chkUpper.UseVisualStyleBackColor = true;
            this.chkUpper.CheckedChanged += new System.EventHandler(this.chkUpper_CheckedChanged);
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Location = new System.Drawing.Point(7, 48);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(124, 17);
            this.chkLower.TabIndex = 0;
            this.chkLower.Text = "Alpha (Lower) [a,b,c]";
            this.chkLower.UseVisualStyleBackColor = true;
            this.chkLower.CheckedChanged += new System.EventHandler(this.chkLower_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.DarkRed;
            this.txtResult.Location = new System.Drawing.Point(11, 171);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(264, 82);
            this.txtResult.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(291, 171);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(140, 82);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate!";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 277);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SR\'s Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbLength;
        private System.Windows.Forms.CheckBox chkBracket;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkSpace;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.CheckBox chkNum;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGenerate;
    }
}

