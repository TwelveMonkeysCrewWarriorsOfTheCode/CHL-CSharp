
namespace SolutionFraction
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MnsMain = new System.Windows.Forms.MenuStrip();
            this.MnsItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TbcMain = new System.Windows.Forms.TabControl();
            this.TbpCalculate = new System.Windows.Forms.TabPage();
            this.RchTxtBoxCalculate = new System.Windows.Forms.RichTextBox();
            this.ChkBoxSaveToFile1 = new System.Windows.Forms.CheckBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.LstOperator = new System.Windows.Forms.ListBox();
            this.TxtFraction2 = new System.Windows.Forms.TextBox();
            this.LblFraction2 = new System.Windows.Forms.Label();
            this.TxtFraction1 = new System.Windows.Forms.TextBox();
            this.LblFraction1 = new System.Windows.Forms.Label();
            this.TbpCompare = new System.Windows.Forms.TabPage();
            this.RchTxtBoxCompare = new System.Windows.Forms.RichTextBox();
            this.ChkBoxSaveToFile2 = new System.Windows.Forms.CheckBox();
            this.TxtResult2 = new System.Windows.Forms.TextBox();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.TxtFraction4 = new System.Windows.Forms.TextBox();
            this.LblFraction4 = new System.Windows.Forms.Label();
            this.TxtFraction3 = new System.Windows.Forms.TextBox();
            this.LblFraction3 = new System.Windows.Forms.Label();
            this.TmrTime = new System.Windows.Forms.Timer(this.components);
            this.MnsMain.SuspendLayout();
            this.TbcMain.SuspendLayout();
            this.TbpCalculate.SuspendLayout();
            this.TbpCompare.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnsMain
            // 
            this.MnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnsItemFile,
            this.MnsItemAbout});
            this.MnsMain.Location = new System.Drawing.Point(0, 0);
            this.MnsMain.Name = "MnsMain";
            this.MnsMain.Size = new System.Drawing.Size(800, 24);
            this.MnsMain.TabIndex = 0;
            this.MnsMain.Text = "MsnMain";
            // 
            // MnsItemFile
            // 
            this.MnsItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnsItemFileExit});
            this.MnsItemFile.Name = "MnsItemFile";
            this.MnsItemFile.Size = new System.Drawing.Size(37, 20);
            this.MnsItemFile.Text = "File";
            // 
            // MnsItemFileExit
            // 
            this.MnsItemFileExit.Name = "MnsItemFileExit";
            this.MnsItemFileExit.ShortcutKeyDisplayString = "Alt+F4";
            this.MnsItemFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MnsItemFileExit.Size = new System.Drawing.Size(135, 22);
            this.MnsItemFileExit.Text = "Exit";
            this.MnsItemFileExit.Click += new System.EventHandler(this.MnsItemFileExit_Click);
            // 
            // MnsItemAbout
            // 
            this.MnsItemAbout.Name = "MnsItemAbout";
            this.MnsItemAbout.Size = new System.Drawing.Size(52, 20);
            this.MnsItemAbout.Text = "About";
            this.MnsItemAbout.Click += new System.EventHandler(this.MnsItemAbout_Click);
            // 
            // TbcMain
            // 
            this.TbcMain.Controls.Add(this.TbpCalculate);
            this.TbcMain.Controls.Add(this.TbpCompare);
            this.TbcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbcMain.Location = new System.Drawing.Point(0, 24);
            this.TbcMain.Name = "TbcMain";
            this.TbcMain.SelectedIndex = 0;
            this.TbcMain.Size = new System.Drawing.Size(800, 427);
            this.TbcMain.TabIndex = 1;
            // 
            // TbpCalculate
            // 
            this.TbpCalculate.Controls.Add(this.RchTxtBoxCalculate);
            this.TbpCalculate.Controls.Add(this.ChkBoxSaveToFile1);
            this.TbpCalculate.Controls.Add(this.TxtResult);
            this.TbpCalculate.Controls.Add(this.BtnCalculate);
            this.TbpCalculate.Controls.Add(this.LstOperator);
            this.TbpCalculate.Controls.Add(this.TxtFraction2);
            this.TbpCalculate.Controls.Add(this.LblFraction2);
            this.TbpCalculate.Controls.Add(this.TxtFraction1);
            this.TbpCalculate.Controls.Add(this.LblFraction1);
            this.TbpCalculate.Location = new System.Drawing.Point(4, 24);
            this.TbpCalculate.Name = "TbpCalculate";
            this.TbpCalculate.Padding = new System.Windows.Forms.Padding(3);
            this.TbpCalculate.Size = new System.Drawing.Size(792, 399);
            this.TbpCalculate.TabIndex = 0;
            this.TbpCalculate.Text = "Calculate";
            this.TbpCalculate.UseVisualStyleBackColor = true;
            // 
            // RchTxtBoxCalculate
            // 
            this.RchTxtBoxCalculate.BackColor = System.Drawing.Color.Black;
            this.RchTxtBoxCalculate.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RchTxtBoxCalculate.ForeColor = System.Drawing.Color.Red;
            this.RchTxtBoxCalculate.Location = new System.Drawing.Point(635, 352);
            this.RchTxtBoxCalculate.Name = "RchTxtBoxCalculate";
            this.RchTxtBoxCalculate.ReadOnly = true;
            this.RchTxtBoxCalculate.Size = new System.Drawing.Size(114, 38);
            this.RchTxtBoxCalculate.TabIndex = 9;
            this.RchTxtBoxCalculate.TabStop = false;
            this.RchTxtBoxCalculate.Text = "";
            // 
            // ChkBoxSaveToFile1
            // 
            this.ChkBoxSaveToFile1.AutoSize = true;
            this.ChkBoxSaveToFile1.Location = new System.Drawing.Point(327, 330);
            this.ChkBoxSaveToFile1.Name = "ChkBoxSaveToFile1";
            this.ChkBoxSaveToFile1.Size = new System.Drawing.Size(135, 19);
            this.ChkBoxSaveToFile1.TabIndex = 8;
            this.ChkBoxSaveToFile1.Text = "Select To Save To File";
            this.ChkBoxSaveToFile1.UseVisualStyleBackColor = true;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(33, 269);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.Size = new System.Drawing.Size(716, 23);
            this.TxtResult.TabIndex = 6;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCalculate.Location = new System.Drawing.Point(33, 176);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(716, 40);
            this.BtnCalculate.TabIndex = 5;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // LstOperator
            // 
            this.LstOperator.FormattingEnabled = true;
            this.LstOperator.ItemHeight = 15;
            this.LstOperator.Location = new System.Drawing.Point(172, 45);
            this.LstOperator.Name = "LstOperator";
            this.LstOperator.Size = new System.Drawing.Size(29, 64);
            this.LstOperator.TabIndex = 4;
            this.LstOperator.SelectedIndexChanged += new System.EventHandler(this.LstOperator_SelectedIndexChanged);
            // 
            // TxtFraction2
            // 
            this.TxtFraction2.Location = new System.Drawing.Point(33, 110);
            this.TxtFraction2.Name = "TxtFraction2";
            this.TxtFraction2.Size = new System.Drawing.Size(100, 23);
            this.TxtFraction2.TabIndex = 3;
            this.TxtFraction2.Text = "21/10";
            // 
            // LblFraction2
            // 
            this.LblFraction2.AutoSize = true;
            this.LblFraction2.Location = new System.Drawing.Point(33, 92);
            this.LblFraction2.Name = "LblFraction2";
            this.LblFraction2.Size = new System.Drawing.Size(56, 15);
            this.LblFraction2.TabIndex = 2;
            this.LblFraction2.Text = "Fraction2";
            // 
            // TxtFraction1
            // 
            this.TxtFraction1.Location = new System.Drawing.Point(33, 45);
            this.TxtFraction1.Name = "TxtFraction1";
            this.TxtFraction1.Size = new System.Drawing.Size(100, 23);
            this.TxtFraction1.TabIndex = 1;
            this.TxtFraction1.Text = "4/15";
            // 
            // LblFraction1
            // 
            this.LblFraction1.AutoSize = true;
            this.LblFraction1.Location = new System.Drawing.Point(33, 27);
            this.LblFraction1.Name = "LblFraction1";
            this.LblFraction1.Size = new System.Drawing.Size(56, 15);
            this.LblFraction1.TabIndex = 0;
            this.LblFraction1.Text = "Fraction1";
            // 
            // TbpCompare
            // 
            this.TbpCompare.Controls.Add(this.RchTxtBoxCompare);
            this.TbpCompare.Controls.Add(this.ChkBoxSaveToFile2);
            this.TbpCompare.Controls.Add(this.TxtResult2);
            this.TbpCompare.Controls.Add(this.BtnCompare);
            this.TbpCompare.Controls.Add(this.TxtFraction4);
            this.TbpCompare.Controls.Add(this.LblFraction4);
            this.TbpCompare.Controls.Add(this.TxtFraction3);
            this.TbpCompare.Controls.Add(this.LblFraction3);
            this.TbpCompare.Location = new System.Drawing.Point(4, 24);
            this.TbpCompare.Name = "TbpCompare";
            this.TbpCompare.Padding = new System.Windows.Forms.Padding(3);
            this.TbpCompare.Size = new System.Drawing.Size(792, 399);
            this.TbpCompare.TabIndex = 1;
            this.TbpCompare.Text = "Compare";
            this.TbpCompare.UseVisualStyleBackColor = true;
            // 
            // RchTxtBoxCompare
            // 
            this.RchTxtBoxCompare.BackColor = System.Drawing.Color.Black;
            this.RchTxtBoxCompare.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RchTxtBoxCompare.ForeColor = System.Drawing.Color.Red;
            this.RchTxtBoxCompare.Location = new System.Drawing.Point(639, 352);
            this.RchTxtBoxCompare.Name = "RchTxtBoxCompare";
            this.RchTxtBoxCompare.ReadOnly = true;
            this.RchTxtBoxCompare.Size = new System.Drawing.Size(114, 38);
            this.RchTxtBoxCompare.TabIndex = 10;
            this.RchTxtBoxCompare.TabStop = false;
            this.RchTxtBoxCompare.Text = "";
            // 
            // ChkBoxSaveToFile2
            // 
            this.ChkBoxSaveToFile2.AutoSize = true;
            this.ChkBoxSaveToFile2.Location = new System.Drawing.Point(325, 282);
            this.ChkBoxSaveToFile2.Name = "ChkBoxSaveToFile2";
            this.ChkBoxSaveToFile2.Size = new System.Drawing.Size(135, 19);
            this.ChkBoxSaveToFile2.TabIndex = 6;
            this.ChkBoxSaveToFile2.Text = "Select To Save To File";
            this.ChkBoxSaveToFile2.UseVisualStyleBackColor = true;
            // 
            // TxtResult2
            // 
            this.TxtResult2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtResult2.Location = new System.Drawing.Point(351, 52);
            this.TxtResult2.Name = "TxtResult2";
            this.TxtResult2.ReadOnly = true;
            this.TxtResult2.Size = new System.Drawing.Size(79, 39);
            this.TxtResult2.TabIndex = 5;
            this.TxtResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCompare
            // 
            this.BtnCompare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCompare.Location = new System.Drawing.Point(31, 172);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(722, 46);
            this.BtnCompare.TabIndex = 4;
            this.BtnCompare.Text = "Compare";
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // TxtFraction4
            // 
            this.TxtFraction4.Location = new System.Drawing.Point(653, 52);
            this.TxtFraction4.Name = "TxtFraction4";
            this.TxtFraction4.Size = new System.Drawing.Size(100, 23);
            this.TxtFraction4.TabIndex = 3;
            this.TxtFraction4.Text = "21/10";
            this.TxtFraction4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblFraction4
            // 
            this.LblFraction4.AutoSize = true;
            this.LblFraction4.Location = new System.Drawing.Point(697, 34);
            this.LblFraction4.Name = "LblFraction4";
            this.LblFraction4.Size = new System.Drawing.Size(56, 15);
            this.LblFraction4.TabIndex = 2;
            this.LblFraction4.Text = "Fraction2";
            // 
            // TxtFraction3
            // 
            this.TxtFraction3.Location = new System.Drawing.Point(31, 52);
            this.TxtFraction3.Name = "TxtFraction3";
            this.TxtFraction3.Size = new System.Drawing.Size(100, 23);
            this.TxtFraction3.TabIndex = 1;
            this.TxtFraction3.Text = "4/15";
            // 
            // LblFraction3
            // 
            this.LblFraction3.AutoSize = true;
            this.LblFraction3.Location = new System.Drawing.Point(31, 34);
            this.LblFraction3.Name = "LblFraction3";
            this.LblFraction3.Size = new System.Drawing.Size(56, 15);
            this.LblFraction3.TabIndex = 0;
            this.LblFraction3.Text = "Fraction1";
            // 
            // TmrTime
            // 
            this.TmrTime.Enabled = true;
            this.TmrTime.Interval = 1000;
            this.TmrTime.Tick += new System.EventHandler(this.TmrTime_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbcMain);
            this.Controls.Add(this.MnsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnsMain;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MnsMain.ResumeLayout(false);
            this.MnsMain.PerformLayout();
            this.TbcMain.ResumeLayout(false);
            this.TbpCalculate.ResumeLayout(false);
            this.TbpCalculate.PerformLayout();
            this.TbpCompare.ResumeLayout(false);
            this.TbpCompare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnsMain;
        private System.Windows.Forms.ToolStripMenuItem MnsItemFile;
        private System.Windows.Forms.ToolStripMenuItem MnsItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem MnsItemAbout;
        private System.Windows.Forms.TabControl TbcMain;
        private System.Windows.Forms.TabPage TbpCalculate;
        private System.Windows.Forms.TabPage TbpCompare;
        private System.Windows.Forms.Label LblFraction2;
        private System.Windows.Forms.Label LblFraction1;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.ListBox LstOperator;
        internal System.Windows.Forms.TextBox TxtFraction2;
        internal System.Windows.Forms.TextBox TxtFraction1;
        private System.Windows.Forms.TextBox TxtFraction4;
        private System.Windows.Forms.Label LblFraction4;
        private System.Windows.Forms.TextBox TxtFraction3;
        private System.Windows.Forms.Label LblFraction3;
        private System.Windows.Forms.Button BtnCompare;
        private System.Windows.Forms.TextBox TxtResult2;
        private System.Windows.Forms.CheckBox ChkBoxSaveToFile1;
        private System.Windows.Forms.CheckBox ChkBoxSaveToFile2;
        private System.Windows.Forms.Timer TmrTime;
        private System.Windows.Forms.RichTextBox RchTxtBoxCalculate;
        private System.Windows.Forms.RichTextBox RchTxtBoxCompare;
    }
}

