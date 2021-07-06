using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using ProjectMathematiqueBLL;

namespace Factorial_Win
{
    public partial class FormFactorielle : Form
    {
        public FormFactorielle()
        {
            InitializeComponent();
            //this.BtnCalculer.Click += this.BtnCalculer_Click; // New Framework
        }

        private void LabelNumber_Click(object sender, EventArgs e)
        {

        }

        private void NumUpDownNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculer_Click(object sender, EventArgs e)
        {
            int number = (int)NumUpDownNumber.Value;
            BigInteger resultat = Factorial.Calculate(number);
            TxtResultat.ScrollBars = ScrollBars.Vertical;
            TxtResultat.Text = resultat.ToString();
        }

        private void NumUpDownNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TrackBarNombre_Scroll(object sender, EventArgs e)
        {
            int number = (int)TrackBarNombre.Value;
            NumUpDownNumber.Text = number.ToString();
        }

        private void BtnCalculerRecursif_Click(object sender, EventArgs e)
        {
            int number = (int)NumUpDownNumber.Value;
            BigInteger resultat = Factorial.CalculateRecursiv(number);
            TxtResultat.ScrollBars = ScrollBars.Vertical;
            TxtResultat.Text = resultat.ToString();
        }
    }
}
