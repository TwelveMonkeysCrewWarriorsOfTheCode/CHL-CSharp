using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFractionBLL;
using ProjectFractionDTO;

namespace SolutionFraction
{
    /// <summary>
    /// Class To Display Main Form
    /// </summary>
    public partial class FormMain : Form
    {
        const string VERSION = "1.0";
        const int FILES = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            this.Text = $"Fraction {VERSION}";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        /// <summary>
        /// Exit Program
        /// </summary>
        private void MnsItemFileExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Exit Program
        }
        /// <summary>
        /// Fill List With Operator
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            List<string>  lstOperators = Fraction.FillListOperator();
            foreach (string line in lstOperators)
            {
                LstOperator.Items.Add(line);
            }
            BtnCalculate.Enabled = false;
            TxtFraction1.Select();
        }
        /// <summary>
        /// Calculate Fraction
        /// </summary>
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            TxtResult.Clear();
            try
            {
                Fraction a = new Fraction(TxtFraction1.Text);
                Fraction b = new Fraction(TxtFraction2.Text);
                string selectedOperator = LstOperator.SelectedItem.ToString();
                switch(selectedOperator)
                {
                    case "+":
                        TxtResult.Text = (a + b).ToString();
                        break;
                    case "-":
                        TxtResult.Text = (a - b).ToString();
                        break;
                    case "*":
                        TxtResult.Text = (a * b).ToString();
                        break;
                    case "/":
                        TxtResult.Text = (a / b).ToString();
                        break;
                    default:
                        TxtResult.Text = (a + b).ToString();
                        break;
                }
                if (ChkBoxSaveToFile1.Checked)
                {
                    using (SaveFileDialog ofd = new SaveFileDialog())
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        ofd.InitialDirectory = ".";
                        ofd.FileName = "FractionCalculateLogs.csv";
                        ofd.OverwritePrompt = false;
                        ofd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            if (ofd.FileName != "")
                            {
                                ResultDTO resultSave = new ResultDTO(false, "", "");
                                IEnumerable<string> record = new string[] 
                                {
                                    DateTime.Now.ToString("dd/MM/yyyy") +
                                    "; " +
                                    DateTime.Now.ToString("HH:mm:ss") +
                                    "; " +
                                    TxtFraction1.Text +
                                    "; " +
                                    selectedOperator +
                                    "; " +
                                    TxtFraction2.Text +
                                    "; " +
                                    TxtResult.Text
                                };
                                DataDTO datatransfert = new DataDTO(record, FILES, ofd.FileName);
                                resultSave = DataTransfertToDAL.SaveData(datatransfert);
                                if (resultSave.PStatus)
                                {
                                    MessageBox.Show($"The {ofd.FileName} has been saved successfully", "", buttons, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(resultSave.PMessageDev, "", buttons, MessageBoxIcon.Error);
                                }
                                ChkBoxSaveToFile1.Checked = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Enable Calculate Button
        /// </summary>
        private void LstOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnCalculate.Enabled = true;            
        }
        /// <summary>
        /// Compare Fraction
        /// </summary>
        private void BtnCompare_Click(object sender, EventArgs e)
        {
            TxtResult2.Clear();
            try
            {
                Fraction a = new Fraction(TxtFraction3.Text);
                Fraction b = new Fraction(TxtFraction4.Text);
                string result;
                if (a < b) result = "<";
                else if (a > b) result = ">";
                else result = "=";
                TxtResult2.Text = result;
                if (ChkBoxSaveToFile2.Checked)
                {
                    using (SaveFileDialog ofd = new SaveFileDialog())
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        ofd.InitialDirectory = ".";
                        ofd.FileName = "FractionCompareLogs.csv";
                        ofd.OverwritePrompt = false;
                        ofd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            if (ofd.FileName != "")
                            {
                                ResultDTO resultSave = new ResultDTO(false, "", "");
                                IEnumerable<string> record = new string[]
                                {
                                    DateTime.Now.ToString("dd/MM/yyyy") +
                                    "; " +
                                    DateTime.Now.ToString("HH:mm:ss") +
                                    "; " +
                                    TxtFraction3.Text +
                                    "; " +
                                    TxtResult2.Text +
                                    "; " +
                                    TxtFraction4.Text                                 
                                };
                                DataDTO datatransfert = new DataDTO(record, FILES, ofd.FileName);
                                resultSave = DataTransfertToDAL.SaveData(datatransfert);
                                if (resultSave.PStatus)
                                {
                                    MessageBox.Show($"The {ofd.FileName} has been saved successfully", "", buttons, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(resultSave.PMessageDev, "", buttons, MessageBoxIcon.Error);
                                }
                                ChkBoxSaveToFile2.Checked = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Display About Box
        /// </summary>
        private void MnsItemAbout_Click(object sender, EventArgs e)
        {
            DlgAbout aboutWindow = new DlgAbout();
            aboutWindow.Show();
        }
        /// <summary>
        /// Clock
        /// </summary>
        private void TmrTime_Tick(object sender, EventArgs e)
        {
            RchTxtBoxCalculate.Text = DateTime.Now.ToLongTimeString();
            RchTxtBoxCompare.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
