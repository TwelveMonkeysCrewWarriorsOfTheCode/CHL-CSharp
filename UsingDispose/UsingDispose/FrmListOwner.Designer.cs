
namespace UsingDispose
{
    partial class FrmListOwner
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
            this.LstVwOwners = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.LstOwner = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstVwOwners
            // 
            this.LstVwOwners.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LstVwOwners.Dock = System.Windows.Forms.DockStyle.Right;
            this.LstVwOwners.HideSelection = false;
            this.LstVwOwners.Location = new System.Drawing.Point(448, 0);
            this.LstVwOwners.Name = "LstVwOwners";
            this.LstVwOwners.Size = new System.Drawing.Size(352, 457);
            this.LstVwOwners.TabIndex = 1;
            this.LstVwOwners.UseCompatibleStateImageBehavior = false;
            this.LstVwOwners.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom Proprio";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Genre";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 100;
            // 
            // LstOwner
            // 
            this.LstOwner.Dock = System.Windows.Forms.DockStyle.Left;
            this.LstOwner.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstOwner.FormattingEnabled = true;
            this.LstOwner.ItemHeight = 14;
            this.LstOwner.Location = new System.Drawing.Point(0, 0);
            this.LstOwner.Name = "LstOwner";
            this.LstOwner.Size = new System.Drawing.Size(376, 457);
            this.LstOwner.TabIndex = 2;
            // 
            // FrmListOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.LstOwner);
            this.Controls.Add(this.LstVwOwners);
            this.Name = "FrmListOwner";
            this.Text = "Liste des propriétaire de compte";
            this.Load += new System.EventHandler(this.FrmListOwner_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView LstVwOwners;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListBox LstOwner;
    }
}