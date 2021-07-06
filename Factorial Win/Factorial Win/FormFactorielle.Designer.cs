
namespace Factorial_Win
{
    partial class FormFactorielle
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
            this.NumUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.BtnCalculer = new System.Windows.Forms.Button();
            this.TxtResultat = new System.Windows.Forms.TextBox();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelResultat = new System.Windows.Forms.Label();
            this.TrackBarNombre = new System.Windows.Forms.TrackBar();
            this.BtnCalculerRecursif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUpDownNumber
            // 
            this.NumUpDownNumber.Location = new System.Drawing.Point(56, 24);
            this.NumUpDownNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumUpDownNumber.Name = "NumUpDownNumber";
            this.NumUpDownNumber.Size = new System.Drawing.Size(120, 23);
            this.NumUpDownNumber.TabIndex = 0;
            this.NumUpDownNumber.ValueChanged += new System.EventHandler(this.NumUpDownNumber_ValueChanged);
            this.NumUpDownNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownNumber_KeyPress);
            // 
            // BtnCalculer
            // 
            this.BtnCalculer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCalculer.Location = new System.Drawing.Point(416, 24);
            this.BtnCalculer.Name = "BtnCalculer";
            this.BtnCalculer.Size = new System.Drawing.Size(120, 32);
            this.BtnCalculer.TabIndex = 1;
            this.BtnCalculer.Text = "Calculer";
            this.BtnCalculer.UseVisualStyleBackColor = true;
            this.BtnCalculer.Click += new System.EventHandler(this.BtnCalculer_Click);
            // 
            // TxtResultat
            // 
            this.TxtResultat.Location = new System.Drawing.Point(57, 112);
            this.TxtResultat.Multiline = true;
            this.TxtResultat.Name = "TxtResultat";
            this.TxtResultat.ReadOnly = true;
            this.TxtResultat.Size = new System.Drawing.Size(480, 208);
            this.TxtResultat.TabIndex = 2;
            this.TxtResultat.TabStop = false;
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabelNumber.Location = new System.Drawing.Point(56, 8);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(51, 15);
            this.LabelNumber.TabIndex = 3;
            this.LabelNumber.Text = "Nombre";
            this.LabelNumber.Click += new System.EventHandler(this.LabelNumber_Click);
            // 
            // LabelResultat
            // 
            this.LabelResultat.AutoSize = true;
            this.LabelResultat.BackColor = System.Drawing.Color.Aqua;
            this.LabelResultat.Location = new System.Drawing.Point(56, 96);
            this.LabelResultat.Name = "LabelResultat";
            this.LabelResultat.Size = new System.Drawing.Size(77, 15);
            this.LabelResultat.TabIndex = 4;
            this.LabelResultat.Text = "LabelResultat";
            // 
            // TrackBarNombre
            // 
            this.TrackBarNombre.Location = new System.Drawing.Point(200, 24);
            this.TrackBarNombre.Maximum = 80;
            this.TrackBarNombre.Name = "TrackBarNombre";
            this.TrackBarNombre.Size = new System.Drawing.Size(104, 45);
            this.TrackBarNombre.TabIndex = 5;
            this.TrackBarNombre.Scroll += new System.EventHandler(this.TrackBarNombre_Scroll);
            // 
            // BtnCalculerRecursif
            // 
            this.BtnCalculerRecursif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCalculerRecursif.Location = new System.Drawing.Point(416, 72);
            this.BtnCalculerRecursif.Name = "BtnCalculerRecursif";
            this.BtnCalculerRecursif.Size = new System.Drawing.Size(123, 31);
            this.BtnCalculerRecursif.TabIndex = 6;
            this.BtnCalculerRecursif.Text = "Calculer Recursif";
            this.BtnCalculerRecursif.UseVisualStyleBackColor = true;
            this.BtnCalculerRecursif.Click += new System.EventHandler(this.BtnCalculerRecursif_Click);
            // 
            // FormFactorielle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Factorial_Win.Properties.Resources.debora_pilati_dOG0z4_gqp0_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 333);
            this.Controls.Add(this.BtnCalculerRecursif);
            this.Controls.Add(this.TrackBarNombre);
            this.Controls.Add(this.LabelResultat);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.TxtResultat);
            this.Controls.Add(this.BtnCalculer);
            this.Controls.Add(this.NumUpDownNumber);
            this.Name = "FormFactorielle";
            this.Text = "FormFactorielle";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumUpDownNumber;
        private System.Windows.Forms.Button BtnCalculer;
        private System.Windows.Forms.TextBox TxtResultat;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelResultat;
        private System.Windows.Forms.TrackBar TrackBarNombre;
        private System.Windows.Forms.Button BtnCalculerRecursif;
    }
}

