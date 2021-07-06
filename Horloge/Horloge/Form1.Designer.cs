
namespace Horloge
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
            this.components = new System.ComponentModel.Container();
            this.BtnStartStop = new System.Windows.Forms.Button();
            this.TxtTime = new System.Windows.Forms.TextBox();
            this.TmrTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BtnStartStop
            // 
            this.BtnStartStop.BackColor = System.Drawing.Color.Silver;
            this.BtnStartStop.BackgroundImage = global::Horloge.Properties.Resources.Button_Play_icon;
            this.BtnStartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStartStop.Location = new System.Drawing.Point(264, 216);
            this.BtnStartStop.Name = "BtnStartStop";
            this.BtnStartStop.Size = new System.Drawing.Size(72, 56);
            this.BtnStartStop.TabIndex = 0;
            this.BtnStartStop.Text = "START";
            this.BtnStartStop.UseVisualStyleBackColor = false;
            // 
            // TxtTime
            // 
            this.TxtTime.BackColor = System.Drawing.Color.Silver;
            this.TxtTime.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTime.ForeColor = System.Drawing.Color.Red;
            this.TxtTime.Location = new System.Drawing.Point(192, 16);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.ReadOnly = true;
            this.TxtTime.Size = new System.Drawing.Size(240, 61);
            this.TxtTime.TabIndex = 1;
            this.TxtTime.TabStop = false;
            this.TxtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TmrTime
            // 
            this.TmrTime.Interval = 1000;
            this.TmrTime.Tick += new System.EventHandler(this.TmrTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Horloge.Properties.Resources.boris_baldinger_VEkIsvDviSs_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 289);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.BtnStartStop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartStop;
        private System.Windows.Forms.TextBox TxtTime;
        private System.Windows.Forms.Timer TmrTime;
    }
}

