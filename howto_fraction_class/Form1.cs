using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace howto_fraction_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            txtPlus.Clear();
            txtMinus.Clear();
            txtTimes.Clear();
            txtDivide.Clear();
            txtDouble.Clear();

            try
            {
                Fraction a = new Fraction(txtFraction1.Text);
                Fraction b = new Fraction(txtFraction2.Text);

                txtPlus.Text = (a + b).ToString();
                txtMinus.Text = (a - b).ToString();
                txtTimes.Text = (a * b).ToString();
                txtDivide.Text = (a / b).ToString();
                txtNegate.Text = (-a).ToString();
                txtDouble.Text = ((double)a).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
