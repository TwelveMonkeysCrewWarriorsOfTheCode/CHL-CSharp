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

namespace SolutionFraction
{
    public partial class FormMain : Form
    {
        const string VERSION = "1.0";

        public FormMain()
        {
            InitializeComponent();
            this.Text = $"Fraction {VERSION}";

        }

        private void MnsItemFileExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Exit Program
        }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LstOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnCalculate.Enabled = true;            
        }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MnsItemAbout_Click(object sender, EventArgs e)
        {
            DlgAbout aboutWindow = new DlgAbout();
            aboutWindow.Show();
        }
    }
}
