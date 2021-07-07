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
        AboutBox aboutWindow;

        public FormMain()
        {
            InitializeComponent();
            this.Text = $"Palindrome {VERSION}";
            aboutWindow = new AboutBox();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Save", "", buttons, MessageBoxIcon.Error);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutWindow = new AboutBox();
            aboutWindow.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0); // Exit Program
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }
    }
}
