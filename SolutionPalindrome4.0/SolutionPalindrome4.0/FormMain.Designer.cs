
namespace SolutionPalindrome4._0
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
            this.MnsItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MnsItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TbcMain = new System.Windows.Forms.TabControl();
            this.TbpText = new System.Windows.Forms.TabPage();
            this.RchTxtTimeText = new System.Windows.Forms.RichTextBox();
            this.LstText = new System.Windows.Forms.ListBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnCheckText = new System.Windows.Forms.Button();
            this.TxtText = new System.Windows.Forms.TextBox();
            this.LblText = new System.Windows.Forms.Label();
            this.TbpFile = new System.Windows.Forms.TabPage();
            this.RchTxtTimeFile = new System.Windows.Forms.RichTextBox();
            this.RchTxtNotPalindrome = new System.Windows.Forms.RichTextBox();
            this.LblNotPalindrome = new System.Windows.Forms.Label();
            this.RchTxtPalindrome = new System.Windows.Forms.RichTextBox();
            this.LblPalindrome = new System.Windows.Forms.Label();
            this.BtnGetFile = new System.Windows.Forms.Button();
            this.TxtNameSelectedFile = new System.Windows.Forms.TextBox();
            this.LblSelectedFile = new System.Windows.Forms.Label();
            this.BtnFile = new System.Windows.Forms.Button();
            this.TmrTime = new System.Windows.Forms.Timer(this.components);
            this.MnsMain.SuspendLayout();
            this.TbcMain.SuspendLayout();
            this.TbpText.SuspendLayout();
            this.TbpFile.SuspendLayout();
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
            this.MnsMain.Text = "MnsMain";
            // 
            // MnsItemFile
            // 
            this.MnsItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnsItemFileSave,
            this.MnsItemSeparator,
            this.MnsItemFileExit});
            this.MnsItemFile.Name = "MnsItemFile";
            this.MnsItemFile.Size = new System.Drawing.Size(37, 20);
            this.MnsItemFile.Text = "File";
            // 
            // MnsItemFileSave
            // 
            this.MnsItemFileSave.Enabled = false;
            this.MnsItemFileSave.Name = "MnsItemFileSave";
            this.MnsItemFileSave.ShortcutKeyDisplayString = "Ctrl+S";
            this.MnsItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MnsItemFileSave.Size = new System.Drawing.Size(138, 22);
            this.MnsItemFileSave.Text = "Save";
            this.MnsItemFileSave.ToolTipText = "Save Palindrome To File";
            this.MnsItemFileSave.Click += new System.EventHandler(this.MnsItemFileSave_Click);
            // 
            // MnsItemSeparator
            // 
            this.MnsItemSeparator.Name = "MnsItemSeparator";
            this.MnsItemSeparator.Size = new System.Drawing.Size(135, 6);
            // 
            // MnsItemFileExit
            // 
            this.MnsItemFileExit.Name = "MnsItemFileExit";
            this.MnsItemFileExit.ShortcutKeyDisplayString = "Alt+F4";
            this.MnsItemFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MnsItemFileExit.Size = new System.Drawing.Size(138, 22);
            this.MnsItemFileExit.Text = "Exit";
            this.MnsItemFileExit.ToolTipText = "Exit Program";
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
            this.TbcMain.Controls.Add(this.TbpText);
            this.TbcMain.Controls.Add(this.TbpFile);
            this.TbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcMain.Location = new System.Drawing.Point(0, 24);
            this.TbcMain.Name = "TbcMain";
            this.TbcMain.SelectedIndex = 0;
            this.TbcMain.Size = new System.Drawing.Size(800, 550);
            this.TbcMain.TabIndex = 1;
            // 
            // TbpText
            // 
            this.TbpText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TbpText.Controls.Add(this.RchTxtTimeText);
            this.TbpText.Controls.Add(this.LstText);
            this.TbpText.Controls.Add(this.LblResult);
            this.TbpText.Controls.Add(this.TxtResult);
            this.TbpText.Controls.Add(this.BtnCheckText);
            this.TbpText.Controls.Add(this.TxtText);
            this.TbpText.Controls.Add(this.LblText);
            this.TbpText.Location = new System.Drawing.Point(4, 24);
            this.TbpText.Name = "TbpText";
            this.TbpText.Padding = new System.Windows.Forms.Padding(3);
            this.TbpText.Size = new System.Drawing.Size(792, 522);
            this.TbpText.TabIndex = 0;
            this.TbpText.Text = "Check Text";
            // 
            // RchTxtTimeText
            // 
            this.RchTxtTimeText.BackColor = System.Drawing.Color.Black;
            this.RchTxtTimeText.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RchTxtTimeText.ForeColor = System.Drawing.Color.Red;
            this.RchTxtTimeText.Location = new System.Drawing.Point(640, 30);
            this.RchTxtTimeText.Name = "RchTxtTimeText";
            this.RchTxtTimeText.ReadOnly = true;
            this.RchTxtTimeText.Size = new System.Drawing.Size(114, 38);
            this.RchTxtTimeText.TabIndex = 6;
            this.RchTxtTimeText.TabStop = false;
            this.RchTxtTimeText.Text = "";
            // 
            // LstText
            // 
            this.LstText.FormattingEnabled = true;
            this.LstText.ItemHeight = 15;
            this.LstText.Location = new System.Drawing.Point(32, 30);
            this.LstText.Name = "LstText";
            this.LstText.Size = new System.Drawing.Size(362, 124);
            this.LstText.TabIndex = 5;
            this.LstText.SelectedIndexChanged += new System.EventHandler(this.LstText_SelectedIndexChanged);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.BackColor = System.Drawing.Color.LightGray;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResult.Location = new System.Drawing.Point(32, 395);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(53, 21);
            this.LblResult.TabIndex = 3;
            this.LblResult.Text = "Result";
            // 
            // TxtResult
            // 
            this.TxtResult.BackColor = System.Drawing.Color.Black;
            this.TxtResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResult.Location = new System.Drawing.Point(32, 419);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.Size = new System.Drawing.Size(722, 29);
            this.TxtResult.TabIndex = 4;
            // 
            // BtnCheckText
            // 
            this.BtnCheckText.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCheckText.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCheckText.Enabled = false;
            this.BtnCheckText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCheckText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCheckText.Location = new System.Drawing.Point(32, 278);
            this.BtnCheckText.Name = "BtnCheckText";
            this.BtnCheckText.Size = new System.Drawing.Size(722, 67);
            this.BtnCheckText.TabIndex = 2;
            this.BtnCheckText.Text = "Check Text";
            this.BtnCheckText.UseVisualStyleBackColor = false;
            this.BtnCheckText.Click += new System.EventHandler(this.BtnCheckText_Click);
            // 
            // TxtText
            // 
            this.TxtText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtText.Location = new System.Drawing.Point(32, 197);
            this.TxtText.Name = "TxtText";
            this.TxtText.Size = new System.Drawing.Size(722, 29);
            this.TxtText.TabIndex = 1;
            this.TxtText.TextChanged += new System.EventHandler(this.TxtText_TextChanged);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.BackColor = System.Drawing.Color.LightGray;
            this.LblText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblText.Location = new System.Drawing.Point(32, 173);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(36, 21);
            this.LblText.TabIndex = 0;
            this.LblText.Text = "Text";
            // 
            // TbpFile
            // 
            this.TbpFile.Controls.Add(this.RchTxtTimeFile);
            this.TbpFile.Controls.Add(this.RchTxtNotPalindrome);
            this.TbpFile.Controls.Add(this.LblNotPalindrome);
            this.TbpFile.Controls.Add(this.RchTxtPalindrome);
            this.TbpFile.Controls.Add(this.LblPalindrome);
            this.TbpFile.Controls.Add(this.BtnGetFile);
            this.TbpFile.Controls.Add(this.TxtNameSelectedFile);
            this.TbpFile.Controls.Add(this.LblSelectedFile);
            this.TbpFile.Controls.Add(this.BtnFile);
            this.TbpFile.Location = new System.Drawing.Point(4, 24);
            this.TbpFile.Name = "TbpFile";
            this.TbpFile.Padding = new System.Windows.Forms.Padding(3);
            this.TbpFile.Size = new System.Drawing.Size(792, 522);
            this.TbpFile.TabIndex = 1;
            this.TbpFile.Text = "Check File";
            this.TbpFile.UseVisualStyleBackColor = true;
            // 
            // RchTxtTimeFile
            // 
            this.RchTxtTimeFile.BackColor = System.Drawing.Color.Black;
            this.RchTxtTimeFile.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RchTxtTimeFile.ForeColor = System.Drawing.Color.Red;
            this.RchTxtTimeFile.Location = new System.Drawing.Point(650, 31);
            this.RchTxtTimeFile.Name = "RchTxtTimeFile";
            this.RchTxtTimeFile.ReadOnly = true;
            this.RchTxtTimeFile.Size = new System.Drawing.Size(114, 38);
            this.RchTxtTimeFile.TabIndex = 8;
            this.RchTxtTimeFile.TabStop = false;
            this.RchTxtTimeFile.Text = "";
            // 
            // RchTxtNotPalindrome
            // 
            this.RchTxtNotPalindrome.BackColor = System.Drawing.Color.Black;
            this.RchTxtNotPalindrome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RchTxtNotPalindrome.ForeColor = System.Drawing.Color.Red;
            this.RchTxtNotPalindrome.Location = new System.Drawing.Point(416, 267);
            this.RchTxtNotPalindrome.Name = "RchTxtNotPalindrome";
            this.RchTxtNotPalindrome.ReadOnly = true;
            this.RchTxtNotPalindrome.Size = new System.Drawing.Size(348, 237);
            this.RchTxtNotPalindrome.TabIndex = 7;
            this.RchTxtNotPalindrome.Text = "";
            // 
            // LblNotPalindrome
            // 
            this.LblNotPalindrome.AutoSize = true;
            this.LblNotPalindrome.BackColor = System.Drawing.Color.Black;
            this.LblNotPalindrome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNotPalindrome.ForeColor = System.Drawing.Color.Red;
            this.LblNotPalindrome.Location = new System.Drawing.Point(416, 243);
            this.LblNotPalindrome.Name = "LblNotPalindrome";
            this.LblNotPalindrome.Size = new System.Drawing.Size(211, 21);
            this.LblNotPalindrome.TabIndex = 6;
            this.LblNotPalindrome.Text = "Result : It is not a palindrome";
            // 
            // RchTxtPalindrome
            // 
            this.RchTxtPalindrome.BackColor = System.Drawing.Color.Black;
            this.RchTxtPalindrome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RchTxtPalindrome.ForeColor = System.Drawing.Color.Yellow;
            this.RchTxtPalindrome.Location = new System.Drawing.Point(26, 261);
            this.RchTxtPalindrome.Name = "RchTxtPalindrome";
            this.RchTxtPalindrome.ReadOnly = true;
            this.RchTxtPalindrome.Size = new System.Drawing.Size(367, 243);
            this.RchTxtPalindrome.TabIndex = 5;
            this.RchTxtPalindrome.Text = "";
            // 
            // LblPalindrome
            // 
            this.LblPalindrome.AutoSize = true;
            this.LblPalindrome.BackColor = System.Drawing.Color.Yellow;
            this.LblPalindrome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPalindrome.Location = new System.Drawing.Point(26, 237);
            this.LblPalindrome.Name = "LblPalindrome";
            this.LblPalindrome.Size = new System.Drawing.Size(184, 21);
            this.LblPalindrome.TabIndex = 4;
            this.LblPalindrome.Text = "Result : It is a palindrome";
            // 
            // BtnGetFile
            // 
            this.BtnGetFile.Enabled = false;
            this.BtnGetFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGetFile.Location = new System.Drawing.Point(26, 182);
            this.BtnGetFile.Name = "BtnGetFile";
            this.BtnGetFile.Size = new System.Drawing.Size(738, 29);
            this.BtnGetFile.TabIndex = 3;
            this.BtnGetFile.Text = "Get File";
            this.BtnGetFile.UseVisualStyleBackColor = true;
            this.BtnGetFile.Click += new System.EventHandler(this.BtnGetFile_Click);
            // 
            // TxtNameSelectedFile
            // 
            this.TxtNameSelectedFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNameSelectedFile.Location = new System.Drawing.Point(26, 117);
            this.TxtNameSelectedFile.Multiline = true;
            this.TxtNameSelectedFile.Name = "TxtNameSelectedFile";
            this.TxtNameSelectedFile.ReadOnly = true;
            this.TxtNameSelectedFile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtNameSelectedFile.Size = new System.Drawing.Size(738, 48);
            this.TxtNameSelectedFile.TabIndex = 2;
            this.TxtNameSelectedFile.TextChanged += new System.EventHandler(this.TxtNameSelectedFile_TextChanged);
            // 
            // LblSelectedFile
            // 
            this.LblSelectedFile.AutoSize = true;
            this.LblSelectedFile.BackColor = System.Drawing.Color.LightGray;
            this.LblSelectedFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSelectedFile.Location = new System.Drawing.Point(26, 93);
            this.LblSelectedFile.Name = "LblSelectedFile";
            this.LblSelectedFile.Size = new System.Drawing.Size(155, 21);
            this.LblSelectedFile.TabIndex = 1;
            this.LblSelectedFile.Text = "Name of selected file";
            // 
            // BtnFile
            // 
            this.BtnFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFile.Location = new System.Drawing.Point(26, 31);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(492, 31);
            this.BtnFile.TabIndex = 0;
            this.BtnFile.Text = "Choose the desired file";
            this.BtnFile.UseVisualStyleBackColor = true;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
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
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.TbcMain);
            this.Controls.Add(this.MnsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MnsMain.ResumeLayout(false);
            this.MnsMain.PerformLayout();
            this.TbcMain.ResumeLayout(false);
            this.TbpText.ResumeLayout(false);
            this.TbpText.PerformLayout();
            this.TbpFile.ResumeLayout(false);
            this.TbpFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnsMain;
        private System.Windows.Forms.ToolStripMenuItem MnsItemFile;
        private System.Windows.Forms.ToolStripMenuItem MnsItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem MnsItemAbout;
        private System.Windows.Forms.ToolStripSeparator MnsItemSeparator;
        private System.Windows.Forms.ToolStripMenuItem MnsItemFileExit;
        private System.Windows.Forms.TabControl TbcMain;
        private System.Windows.Forms.TabPage TbpText;
        private System.Windows.Forms.TabPage TbpFile;
        private System.Windows.Forms.TextBox TxtText;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Button BtnCheckText;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Label LblSelectedFile;
        private System.Windows.Forms.TextBox TxtNameSelectedFile;
        private System.Windows.Forms.Button BtnGetFile;
        private System.Windows.Forms.Label LblPalindrome;
        private System.Windows.Forms.RichTextBox RchTxtPalindrome;
        private System.Windows.Forms.Label LblNotPalindrome;
        private System.Windows.Forms.RichTextBox RchTxtNotPalindrome;
        private System.Windows.Forms.ListBox LstText;
        private System.Windows.Forms.RichTextBox RchTxtTimeText;
        private System.Windows.Forms.Timer TmrTime;
        private System.Windows.Forms.RichTextBox RchTxtTimeFile;
    }
}

