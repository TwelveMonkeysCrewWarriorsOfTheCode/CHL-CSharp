using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingDispose
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            using (FrmCreateAccount myFrm = new FrmCreateAccount())
            {
                myFrm.ShowDialog();
            }
        }
    }
}
