using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionPalindrome4._0
{
    public partial class FormMain : Form
    {
        const string VERSION = "4.0";

        public FormMain()
        {
            InitializeComponent();
            this.Text = $"Palindrome {VERSION}";
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Exit Program
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form dlg1 = new Form();
            dlg1.ShowDialog();
        }
    }
}
