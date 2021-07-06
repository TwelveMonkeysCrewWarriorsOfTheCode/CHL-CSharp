using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horloge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.BtnStartStop.Click += new System.EventHandler(this.BtnStart_Click); // Framework 1.0
            this.BtnStartStop.Click += this.BtnStart_Click; // New Framework
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TmrTime_Tick(BtnStartStop, null);
            TmrTime.Enabled = true;
            BtnStartStop.Text = "STOP";
            this.BtnStartStop.Click -= this.BtnStart_Click;
            this.BtnStartStop.Click += this.BtnStop_Click;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TmrTime.Enabled = false;
            BtnStartStop.Text = "START";
            this.BtnStartStop.Click -= this.BtnStop_Click;
            this.BtnStartStop.Click += this.BtnStart_Click;
        }

        private void TmrTime_Tick(object sender, EventArgs e)
        {
            TxtTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
