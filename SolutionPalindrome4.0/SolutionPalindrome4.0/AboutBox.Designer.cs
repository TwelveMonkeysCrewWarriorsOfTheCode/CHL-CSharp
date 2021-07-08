
namespace SolutionPalindrome4._0
{
    partial class DlgAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgAbout));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.LblProductName = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.LblCopyright = new System.Windows.Forms.Label();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.08419F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.91581F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.LblProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.LblVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.LblCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.LblCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.TxtDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.BtnOK, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(487, 307);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(4, 3);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(270, 301);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // LblProductName
            // 
            this.LblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblProductName.Location = new System.Drawing.Point(285, 0);
            this.LblProductName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.LblProductName.MaximumSize = new System.Drawing.Size(0, 20);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(198, 20);
            this.LblProductName.TabIndex = 19;
            this.LblProductName.Text = "Palindrome";
            this.LblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblVersion
            // 
            this.LblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblVersion.Location = new System.Drawing.Point(285, 30);
            this.LblVersion.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.LblVersion.MaximumSize = new System.Drawing.Size(0, 20);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(198, 20);
            this.LblVersion.TabIndex = 0;
            this.LblVersion.Text = "4.0";
            this.LblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCopyright
            // 
            this.LblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCopyright.Location = new System.Drawing.Point(285, 60);
            this.LblCopyright.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.LblCopyright.MaximumSize = new System.Drawing.Size(0, 20);
            this.LblCopyright.Name = "LblCopyright";
            this.LblCopyright.Size = new System.Drawing.Size(198, 20);
            this.LblCopyright.TabIndex = 21;
            this.LblCopyright.Text = "Copyright (C) Lambert Christian";
            this.LblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCompanyName.Location = new System.Drawing.Point(285, 90);
            this.LblCompanyName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.LblCompanyName.MaximumSize = new System.Drawing.Size(0, 20);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(198, 20);
            this.LblCompanyName.TabIndex = 22;
            this.LblCompanyName.Text = "Gremlins Company";
            this.LblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDescription.Location = new System.Drawing.Point(285, 123);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(7, 3, 4, 3);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ReadOnly = true;
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDescription.Size = new System.Drawing.Size(198, 147);
            this.TxtDescription.TabIndex = 23;
            this.TxtDescription.TabStop = false;
            this.TxtDescription.Text = "Ce programme permet de tester si un mot ou une phrase est un palindrom";
            this.TxtDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnOK.Location = new System.Drawing.Point(395, 277);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(88, 27);
            this.BtnOK.TabIndex = 24;
            this.BtnOK.Text = "&OK";
            this.BtnOK.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DlgAbout
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 327);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgAbout";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label LblCopyright;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Button BtnOK;
    }
}
