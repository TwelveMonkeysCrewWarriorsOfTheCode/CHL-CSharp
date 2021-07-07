
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
            this.SuspendLayout();
            // 
            // LstMouvements
            // 
            this.LstMouvements.FormattingEnabled = true;
            this.LstMouvements.ItemHeight = 15;
            this.LstMouvements.Location = new System.Drawing.Point(432, 16);
            this.LstMouvements.Name = "LstMouvements";
            this.LstMouvements.Size = new System.Drawing.Size(344, 409);
            this.LstMouvements.TabIndex = 0;
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Location = new System.Drawing.Point(64, 24);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(304, 23);
            this.BtnCreateAccount.TabIndex = 1;
            this.BtnCreateAccount.Text = "Céation compte bancaire";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.LstMouvements);
            this.Name = "FrmMain";
            this.Text = "Comptes Bancaire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstMouvements;
        private System.Windows.Forms.Button BtnCreateAccount;
    }
}

