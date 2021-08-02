
namespace UsingDispose
{
    partial class FrmMain
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
            this.LstMouvements = new System.Windows.Forms.ListBox();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.GrpDetailAccount = new System.Windows.Forms.GroupBox();
            this.TxtAccountType = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TxtGender = new System.Windows.Forms.TextBox();
            this.TxtOwnerName = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesPropriétaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpDetailAccount.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstMouvements
            // 
            this.LstMouvements.FormattingEnabled = true;
            this.LstMouvements.ItemHeight = 15;
            this.LstMouvements.Location = new System.Drawing.Point(432, 48);
            this.LstMouvements.Name = "LstMouvements";
            this.LstMouvements.Size = new System.Drawing.Size(344, 364);
            this.LstMouvements.TabIndex = 0;
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Location = new System.Drawing.Point(64, 32);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(304, 23);
            this.BtnCreateAccount.TabIndex = 1;
            this.BtnCreateAccount.Text = "Création compte bancaire";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // GrpDetailAccount
            // 
            this.GrpDetailAccount.Controls.Add(this.TxtAccountType);
            this.GrpDetailAccount.Controls.Add(this.textBox3);
            this.GrpDetailAccount.Controls.Add(this.TxtGender);
            this.GrpDetailAccount.Controls.Add(this.TxtOwnerName);
            this.GrpDetailAccount.Enabled = false;
            this.GrpDetailAccount.Location = new System.Drawing.Point(64, 64);
            this.GrpDetailAccount.Name = "GrpDetailAccount";
            this.GrpDetailAccount.Size = new System.Drawing.Size(304, 168);
            this.GrpDetailAccount.TabIndex = 2;
            this.GrpDetailAccount.TabStop = false;
            this.GrpDetailAccount.Text = "Detail Compte Bancaire";
            // 
            // TxtAccountType
            // 
            this.TxtAccountType.Location = new System.Drawing.Point(8, 120);
            this.TxtAccountType.Name = "TxtAccountType";
            this.TxtAccountType.Size = new System.Drawing.Size(288, 23);
            this.TxtAccountType.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(240, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 2;
            // 
            // TxtGender
            // 
            this.TxtGender.Location = new System.Drawing.Point(8, 72);
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(288, 23);
            this.TxtGender.TabIndex = 1;
            // 
            // TxtOwnerName
            // 
            this.TxtOwnerName.Location = new System.Drawing.Point(8, 24);
            this.TxtOwnerName.Name = "TxtOwnerName";
            this.TxtOwnerName.Size = new System.Drawing.Size(288, 23);
            this.TxtOwnerName.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(64, 256);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(304, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Sauver le compte";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesPropriétaireToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.displayToolStripMenuItem.Text = "View";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // listeDesPropriétaireToolStripMenuItem
            // 
            this.listeDesPropriétaireToolStripMenuItem.Name = "listeDesPropriétaireToolStripMenuItem";
            this.listeDesPropriétaireToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listeDesPropriétaireToolStripMenuItem.Text = "Liste des propriétaire";
            this.listeDesPropriétaireToolStripMenuItem.Click += new System.EventHandler(this.listeDesPropriétaireToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GrpDetailAccount);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.LstMouvements);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Comptes Bancaire";
            this.GrpDetailAccount.ResumeLayout(false);
            this.GrpDetailAccount.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstMouvements;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.GroupBox GrpDetailAccount;
        private System.Windows.Forms.TextBox TxtAccountType;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TxtGender;
        private System.Windows.Forms.TextBox TxtOwnerName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesPropriétaireToolStripMenuItem;
    }
}

