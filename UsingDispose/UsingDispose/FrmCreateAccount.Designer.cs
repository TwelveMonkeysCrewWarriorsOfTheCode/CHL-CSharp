
namespace UsingDispose
{
    partial class FrmCreateAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOwnerName = new System.Windows.Forms.TextBox();
            this.RdbMasculin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.RdbFeminin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.RdbCurrent = new System.Windows.Forms.RadioButton();
            this.RdbSaving = new System.Windows.Forms.RadioButton();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GrpGender = new System.Windows.Forms.GroupBox();
            this.RdbInconnu = new System.Windows.Forms.RadioButton();
            this.GrpAccountType = new System.Windows.Forms.GroupBox();
            this.GrpGender.SuspendLayout();
            this.GrpAccountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du propiétaire";
            // 
            // TxtOwnerName
            // 
            this.TxtOwnerName.Location = new System.Drawing.Point(168, 16);
            this.TxtOwnerName.Name = "TxtOwnerName";
            this.TxtOwnerName.Size = new System.Drawing.Size(480, 23);
            this.TxtOwnerName.TabIndex = 1;
            this.TxtOwnerName.TextChanged += new System.EventHandler(this.TxtOwnerName_TextChanged);
            // 
            // RdbMasculin
            // 
            this.RdbMasculin.AutoSize = true;
            this.RdbMasculin.Location = new System.Drawing.Point(16, 24);
            this.RdbMasculin.Name = "RdbMasculin";
            this.RdbMasculin.Size = new System.Drawing.Size(73, 19);
            this.RdbMasculin.TabIndex = 2;
            this.RdbMasculin.TabStop = true;
            this.RdbMasculin.Text = "Masculin";
            this.RdbMasculin.UseVisualStyleBackColor = true;
            this.RdbMasculin.CheckedChanged += new System.EventHandler(this.RdbGender_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genre du propriétaire";
            // 
            // RdbFeminin
            // 
            this.RdbFeminin.AutoSize = true;
            this.RdbFeminin.Location = new System.Drawing.Point(112, 24);
            this.RdbFeminin.Name = "RdbFeminin";
            this.RdbFeminin.Size = new System.Drawing.Size(68, 19);
            this.RdbFeminin.TabIndex = 4;
            this.RdbFeminin.TabStop = true;
            this.RdbFeminin.Text = "Féminin";
            this.RdbFeminin.UseVisualStyleBackColor = true;
            this.RdbFeminin.CheckedChanged += new System.EventHandler(this.RdbGender_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type de compte";
            // 
            // RdbCurrent
            // 
            this.RdbCurrent.AutoSize = true;
            this.RdbCurrent.Location = new System.Drawing.Point(16, 8);
            this.RdbCurrent.Name = "RdbCurrent";
            this.RdbCurrent.Size = new System.Drawing.Size(112, 19);
            this.RdbCurrent.TabIndex = 6;
            this.RdbCurrent.TabStop = true;
            this.RdbCurrent.Text = "Compte courant";
            this.RdbCurrent.UseVisualStyleBackColor = true;
            this.RdbCurrent.CheckedChanged += new System.EventHandler(this.RdbAccount_CheckedChanged);
            // 
            // RdbSaving
            // 
            this.RdbSaving.AutoSize = true;
            this.RdbSaving.Location = new System.Drawing.Point(152, 8);
            this.RdbSaving.Name = "RdbSaving";
            this.RdbSaving.Size = new System.Drawing.Size(114, 19);
            this.RdbSaving.TabIndex = 7;
            this.RdbSaving.TabStop = true;
            this.RdbSaving.Text = "Compte épargne";
            this.RdbSaving.UseVisualStyleBackColor = true;
            this.RdbSaving.CheckedChanged += new System.EventHandler(this.RdbAccount_CheckedChanged);
            // 
            // BtnOK
            // 
            this.BtnOK.Enabled = false;
            this.BtnOK.Location = new System.Drawing.Point(40, 408);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(696, 416);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GrpGender
            // 
            this.GrpGender.Controls.Add(this.RdbMasculin);
            this.GrpGender.Controls.Add(this.RdbFeminin);
            this.GrpGender.Controls.Add(this.RdbInconnu);
            this.GrpGender.Location = new System.Drawing.Point(176, 48);
            this.GrpGender.Name = "GrpGender";
            this.GrpGender.Size = new System.Drawing.Size(344, 56);
            this.GrpGender.TabIndex = 10;
            this.GrpGender.TabStop = false;
            // 
            // RdbInconnu
            // 
            this.RdbInconnu.AutoSize = true;
            this.RdbInconnu.Location = new System.Drawing.Point(208, 24);
            this.RdbInconnu.Name = "RdbInconnu";
            this.RdbInconnu.Size = new System.Drawing.Size(69, 19);
            this.RdbInconnu.TabIndex = 0;
            this.RdbInconnu.TabStop = true;
            this.RdbInconnu.Text = "Inconnu";
            this.RdbInconnu.UseVisualStyleBackColor = true;
            this.RdbInconnu.CheckedChanged += new System.EventHandler(this.RdbGender_CheckedChanged);
            // 
            // GrpAccountType
            // 
            this.GrpAccountType.Controls.Add(this.RdbCurrent);
            this.GrpAccountType.Controls.Add(this.RdbSaving);
            this.GrpAccountType.Location = new System.Drawing.Point(176, 104);
            this.GrpAccountType.Name = "GrpAccountType";
            this.GrpAccountType.Size = new System.Drawing.Size(328, 48);
            this.GrpAccountType.TabIndex = 11;
            this.GrpAccountType.TabStop = false;
            // 
            // FrmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrpAccountType);
            this.Controls.Add(this.GrpGender);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOwnerName);
            this.Controls.Add(this.label1);
            this.Name = "FrmCreateAccount";
            this.Text = "Création d\'un compte bancaire";
            this.GrpGender.ResumeLayout(false);
            this.GrpGender.PerformLayout();
            this.GrpAccountType.ResumeLayout(false);
            this.GrpAccountType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOwnerName;
        private System.Windows.Forms.RadioButton RdbMasculin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RdbFeminin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RdbCurrent;
        private System.Windows.Forms.RadioButton RdbSaving;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox GrpGender;
        private System.Windows.Forms.GroupBox GrpAccountType;
        private System.Windows.Forms.RadioButton RdbInconnu;
    }
}