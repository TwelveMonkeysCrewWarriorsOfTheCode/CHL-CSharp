using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProjectPalindromeBLL;
using ProjectPalindromeDAL;

namespace Palindrome_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Palindrome Win";
        }

        private void BtnGetFile_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = ".";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    TxtPathFile.Text = ofd.FileName;
                    RichTextResultPalindrome.Clear();
                    RichTextResultNonPalindrome.Clear();
                }
            }
        }

        private void BtnTestPalindrome_Click(object sender, EventArgs e)
        {
            string input = TxtTexte.Text;
            ResultBLL resultpalindrome = PalindromeBLL.ValidEntryTextAndCheckPalindrome(input); // Check the text validity and palindrome
            if (resultpalindrome.PStatus != Status.error) // Not Error
            {
                RichTextBoxTexte.BackColor = Color.Black;
                if (resultpalindrome.PStatus == Status.ispalindrome)
                {
                    string messageresultat = input + " est un palindrome";
                    RichTextBoxTexte.ForeColor = Color.Yellow;
                    RichTextBoxTexte.Text = messageresultat;
                }
                else
                {
                    string messageresultat = input + " n'est pas un palindrome";
                    RichTextBoxTexte.ForeColor = Color.Red;
                    RichTextBoxTexte.Text = messageresultat;
                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Un texte ne peut pas être null ou ne contenir que des espaces et doit avoir au moins 2 caractères !!!", "", buttons, MessageBoxIcon.Error);
            }
        }

        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            string filename = TxtPathFile.Text;
            Records records; // Records
            records = PalindromeBLL.CheckPalindromeFromFile(filename);
            if (records.PStatus) // Not Error
            {
                RichTextResultPalindrome.BackColor = Color.Black;
                RichTextResultNonPalindrome.BackColor = Color.Black;
                RichTextResultPalindrome.ForeColor = Color.Yellow;
                RichTextResultNonPalindrome.ForeColor = Color.Red;
                StringBuilder messageresultatpalindrome = new StringBuilder();
                StringBuilder messageresultatnonpalindrome = new StringBuilder();
                foreach (string line in records.PRecords)
                {
                    bool result = PalindromeBLL.IsPalindrome(line);
                    if (result)
                    {
                        //messageresultatpalindrome.Append(line + " est un palindrome\r\n");
                        messageresultatpalindrome.Append(line + "\r\n");
                    }
                    else
                    {
                        //messageresultatnonpalindrome.Append(line + " n'est pas un palindrome\r\n");
                        messageresultatnonpalindrome.Append(line + "\r\n");
                    }
                }
                RichTextResultPalindrome.Text = messageresultatpalindrome.ToString();
                RichTextResultNonPalindrome.Text = messageresultatnonpalindrome.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(records.PMessageDev, records.PMessageExc, buttons, MessageBoxIcon.Error);
            }
        }

        private void TxtTexte_TextChanged(object sender, EventArgs e)
        {
            if (TxtTexte.Text.Trim().Length < 2)
            {
                BtnTestPalindrome.Enabled = false;
            }
            else
            {
                BtnTestPalindrome.Enabled = true;
            }
        }

        private void TxtPathFile_TextChanged(object sender, EventArgs e)
        {
            BtnReadFile.Enabled = true;
        }
    }
}

