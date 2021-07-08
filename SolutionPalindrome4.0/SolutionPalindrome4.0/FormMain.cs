using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectPalindromeDAL;
using ProjectPalindromeBLL;

namespace SolutionPalindrome4._0
{
    public partial class FormMain : Form
    {
        const string VERSION = "4.0";
        DlgAbout aboutWindow;

        public FormMain()
        {
            InitializeComponent();
            this.Text = $"Palindrome {VERSION}";
            aboutWindow = new DlgAbout();

        }

        private void MnsItemFileSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ofd = new SaveFileDialog())
            {
                ofd.InitialDirectory = ".";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName != "")
                    {
                        if (TbcMain.SelectedTab == TbpText)
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show($"Save {ofd.FileName} Text", "", buttons, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show($"Save {ofd.FileName} File", "", buttons, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            //ResultDAL valid = PalindromeDAL.SaveRecords(input, resultfilenameextension.PFilename); // Save record to file in append mode

            //MessageBoxButtons buttons = MessageBoxButtons.OK;
            //MessageBox.Show("Save", "", buttons, MessageBoxIcon.Error);
        }

        private void MnsItemAbout_Click(object sender, EventArgs e)
        {
            DlgAbout aboutWindow = new DlgAbout();
            aboutWindow.Show();
        }

        private void MnsItemFileExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Exit Program
        }

        private void BtnCheckText_Click(object sender, EventArgs e)
        {
            string input = TxtText.Text;
            ResultBLL resultpalindrome = PalindromeBLL.ValidEntryTextAndCheckPalindrome(input); // Check the text validity and palindrome
            if (resultpalindrome.PStatus != Status.error) // Not Error
            {
                TxtResult.BackColor = Color.Black;
                if (resultpalindrome.PStatus == Status.ispalindrome)
                {
                    string messageresultat = input + " is a palindrome";
                    TxtResult.ForeColor = Color.Yellow;
                    TxtResult.Text = messageresultat;
                }
                else
                {
                    string messageresultat = input + " is not a palindrome";
                    TxtResult.ForeColor = Color.Red;
                    TxtResult.Text = messageresultat;
                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("A text cannot be null or contain only spaces and must have at least 2 characters !!!", "", buttons, MessageBoxIcon.Error);
            }
        }

        private void TxtText_TextChanged(object sender, EventArgs e)
        {
            if (TxtText.Text.Trim().Length < 2)
            {
                BtnCheckText.Enabled = false;
            }
            else
            {
                BtnCheckText.Enabled = true;
            }
            TxtResult.Clear();
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = ".";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    TxtNameSelectedFile.Text = ofd.FileName;
                    RchTxtPalindrome.Clear();
                    RchTxtNotPalindrome.Clear();
                }
            }
        }

        private void BtnGetFile_Click(object sender, EventArgs e)
        {
            string filename = TxtNameSelectedFile.Text;
            Records records; // Records
            records = PalindromeBLL.GetPalindromeFromFile(filename);
            if (records.PStatus) // Not Error
            {
                RchTxtPalindrome.BackColor = Color.Black;
                RchTxtNotPalindrome.BackColor = Color.Black;
                RchTxtPalindrome.ForeColor = Color.Yellow;
                RchTxtNotPalindrome.ForeColor = Color.Red;
                StringBuilder messageresultatpalindrome = new StringBuilder();
                StringBuilder messageresultatnonpalindrome = new StringBuilder();
                foreach (string line in records.PRecords)
                {
                    bool result = PalindromeBLL.IsPalindrome(line);
                    if (result)
                    {
                        messageresultatpalindrome.Append(line + "\r\n");
                    }
                    else
                    {
                        messageresultatnonpalindrome.Append(line + "\r\n");
                    }
                }
                RchTxtPalindrome.Text = messageresultatpalindrome.ToString();
                RchTxtNotPalindrome.Text = messageresultatnonpalindrome.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(records.PMessageDev, records.PMessageExc, buttons, MessageBoxIcon.Error);
            }
        }

        private void TxtNameSelectedFile_TextChanged(object sender, EventArgs e)
        {
            BtnGetFile.Enabled = true;
        }
    }
}
