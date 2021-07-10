
namespace Palindrome_Win
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RichTextBoxTexte = new System.Windows.Forms.RichTextBox();
            this.LabResultat = new System.Windows.Forms.Label();
            this.BtnTestPalindrome = new System.Windows.Forms.Button();
            this.LabTexte = new System.Windows.Forms.Label();
            this.TxtTexte = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LabResult2 = new System.Windows.Forms.Label();
            this.RichTextResultNonPalindrome = new System.Windows.Forms.RichTextBox();
            this.RichTextResultPalindrome = new System.Windows.Forms.RichTextBox();
            this.LabFile = new System.Windows.Forms.Label();
            this.LabResult = new System.Windows.Forms.Label();
            this.BtnReadFile = new System.Windows.Forms.Button();
            this.TxtPathFile = new System.Windows.Forms.TextBox();
            this.BtnGetFile = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RichTextBoxTexte);
            this.tabPage1.Controls.Add(this.LabResultat);
            this.tabPage1.Controls.Add(this.BtnTestPalindrome);
            this.tabPage1.Controls.Add(this.LabTexte);
            this.tabPage1.Controls.Add(this.TxtTexte);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Texte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RichTextBoxTexte
            // 
            this.RichTextBoxTexte.BackColor = System.Drawing.Color.Black;
            this.RichTextBoxTexte.Location = new System.Drawing.Point(24, 176);
            this.RichTextBoxTexte.Name = "RichTextBoxTexte";
            this.RichTextBoxTexte.ReadOnly = true;
            this.RichTextBoxTexte.Size = new System.Drawing.Size(744, 24);
            this.RichTextBoxTexte.TabIndex = 5;
            this.RichTextBoxTexte.Text = "";
            // 
            // LabResultat
            // 
            this.LabResultat.AutoSize = true;
            this.LabResultat.Location = new System.Drawing.Point(24, 160);
            this.LabResultat.Name = "LabResultat";
            this.LabResultat.Size = new System.Drawing.Size(49, 15);
            this.LabResultat.TabIndex = 4;
            this.LabResultat.Text = "Resultat";
            // 
            // BtnTestPalindrome
            // 
            this.BtnTestPalindrome.Enabled = false;
            this.BtnTestPalindrome.Location = new System.Drawing.Point(24, 88);
            this.BtnTestPalindrome.Name = "BtnTestPalindrome";
            this.BtnTestPalindrome.Size = new System.Drawing.Size(744, 48);
            this.BtnTestPalindrome.TabIndex = 2;
            this.BtnTestPalindrome.Text = "Test Si Palindrome";
            this.BtnTestPalindrome.UseVisualStyleBackColor = true;
            this.BtnTestPalindrome.Click += new System.EventHandler(this.BtnTestPalindrome_Click);
            // 
            // LabTexte
            // 
            this.LabTexte.AutoSize = true;
            this.LabTexte.Location = new System.Drawing.Point(24, 16);
            this.LabTexte.Name = "LabTexte";
            this.LabTexte.Size = new System.Drawing.Size(34, 15);
            this.LabTexte.TabIndex = 1;
            this.LabTexte.Text = "Texte";
            // 
            // TxtTexte
            // 
            this.TxtTexte.Location = new System.Drawing.Point(24, 32);
            this.TxtTexte.Name = "TxtTexte";
            this.TxtTexte.ShortcutsEnabled = false;
            this.TxtTexte.Size = new System.Drawing.Size(744, 23);
            this.TxtTexte.TabIndex = 0;
            this.TxtTexte.TextChanged += new System.EventHandler(this.TxtTexte_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LabResult2);
            this.tabPage2.Controls.Add(this.RichTextResultNonPalindrome);
            this.tabPage2.Controls.Add(this.RichTextResultPalindrome);
            this.tabPage2.Controls.Add(this.LabFile);
            this.tabPage2.Controls.Add(this.LabResult);
            this.tabPage2.Controls.Add(this.BtnReadFile);
            this.tabPage2.Controls.Add(this.TxtPathFile);
            this.tabPage2.Controls.Add(this.BtnGetFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fichier";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LabResult2
            // 
            this.LabResult2.AutoSize = true;
            this.LabResult2.BackColor = System.Drawing.Color.Red;
            this.LabResult2.Location = new System.Drawing.Point(424, 144);
            this.LabResult2.Name = "LabResult2";
            this.LabResult2.Size = new System.Drawing.Size(197, 15);
            this.LabResult2.TabIndex = 8;
            this.LabResult2.Text = "Résultat: ce n\'est pas un palindrome";
            // 
            // RichTextResultNonPalindrome
            // 
            this.RichTextResultNonPalindrome.BackColor = System.Drawing.Color.Black;
            this.RichTextResultNonPalindrome.Location = new System.Drawing.Point(424, 160);
            this.RichTextResultNonPalindrome.Name = "RichTextResultNonPalindrome";
            this.RichTextResultNonPalindrome.ReadOnly = true;
            this.RichTextResultNonPalindrome.Size = new System.Drawing.Size(344, 248);
            this.RichTextResultNonPalindrome.TabIndex = 7;
            this.RichTextResultNonPalindrome.Text = "";
            // 
            // RichTextResultPalindrome
            // 
            this.RichTextResultPalindrome.BackColor = System.Drawing.Color.Black;
            this.RichTextResultPalindrome.Location = new System.Drawing.Point(24, 160);
            this.RichTextResultPalindrome.Name = "RichTextResultPalindrome";
            this.RichTextResultPalindrome.ReadOnly = true;
            this.RichTextResultPalindrome.Size = new System.Drawing.Size(360, 248);
            this.RichTextResultPalindrome.TabIndex = 6;
            this.RichTextResultPalindrome.Text = "";
            // 
            // LabFile
            // 
            this.LabFile.AutoSize = true;
            this.LabFile.Location = new System.Drawing.Point(24, 56);
            this.LabFile.Name = "LabFile";
            this.LabFile.Size = new System.Drawing.Size(154, 15);
            this.LabFile.TabIndex = 5;
            this.LabFile.Text = "Nom Du Fichier Sélectionné";
            // 
            // LabResult
            // 
            this.LabResult.AutoSize = true;
            this.LabResult.BackColor = System.Drawing.Color.Yellow;
            this.LabResult.Location = new System.Drawing.Point(24, 144);
            this.LabResult.Name = "LabResult";
            this.LabResult.Size = new System.Drawing.Size(160, 15);
            this.LabResult.TabIndex = 4;
            this.LabResult.Text = "Résultat: c\'est un palindrome";
            // 
            // BtnReadFile
            // 
            this.BtnReadFile.Enabled = false;
            this.BtnReadFile.Location = new System.Drawing.Point(24, 112);
            this.BtnReadFile.Name = "BtnReadFile";
            this.BtnReadFile.Size = new System.Drawing.Size(744, 23);
            this.BtnReadFile.TabIndex = 2;
            this.BtnReadFile.Text = "Lire le fichier";
            this.BtnReadFile.UseVisualStyleBackColor = true;
            this.BtnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click);
            // 
            // TxtPathFile
            // 
            this.TxtPathFile.Location = new System.Drawing.Point(24, 72);
            this.TxtPathFile.Name = "TxtPathFile";
            this.TxtPathFile.ReadOnly = true;
            this.TxtPathFile.Size = new System.Drawing.Size(744, 23);
            this.TxtPathFile.TabIndex = 1;
            this.TxtPathFile.TabStop = false;
            this.TxtPathFile.TextChanged += new System.EventHandler(this.TxtPathFile_TextChanged);
            // 
            // BtnGetFile
            // 
            this.BtnGetFile.Location = new System.Drawing.Point(24, 24);
            this.BtnGetFile.Name = "BtnGetFile";
            this.BtnGetFile.Size = new System.Drawing.Size(744, 23);
            this.BtnGetFile.TabIndex = 0;
            this.BtnGetFile.Text = "Choisir le fichier désiré";
            this.BtnGetFile.UseVisualStyleBackColor = true;
            this.BtnGetFile.Click += new System.EventHandler(this.BtnGetFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnGetFile;
        private System.Windows.Forms.TextBox TxtPathFile;
        private System.Windows.Forms.Button BtnReadFile;
        private System.Windows.Forms.Button BtnTestPalindrome;
        private System.Windows.Forms.Label LabTexte;
        private System.Windows.Forms.TextBox TxtTexte;
        private System.Windows.Forms.Label LabResultat;
        private System.Windows.Forms.Label LabResult;
        private System.Windows.Forms.Label LabFile;
        private System.Windows.Forms.RichTextBox RichTextResultPalindrome;
        private System.Windows.Forms.RichTextBox RichTextResultNonPalindrome;
        private System.Windows.Forms.Label LabResult2;
        private System.Windows.Forms.RichTextBox RichTextBoxTexte;
    }
}

