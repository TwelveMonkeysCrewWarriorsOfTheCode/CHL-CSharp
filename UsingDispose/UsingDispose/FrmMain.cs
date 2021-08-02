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
                if (myFrm != null)
                { 
                    TxtOwnerName.Text = myFrm.CreatedAccount.OwnerName;
                    TxtGender.Text = myFrm.CreatedAccount.Sex.ToString();
                    TxtAccountType.Text = myFrm.CreatedAccount.Type.ToString();
                    BtnSave.Tag = myFrm.CreatedAccount;
                }
                //myFrm.ShowDialog();
                //MessageBox.Show($"{myFrm.CreatedAccount.OwnerName},{myFrm.CreatedAccount.Sex},{myFrm.CreatedAccount.Type}");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            BLL.BankAccountBLL accountToSave = BtnSave.Tag as BLL.BankAccountBLL;
            bool result = accountToSave.SaveAccount();
            MessageBox.Show($"Résultat du save {result}");
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeDesPropriétaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmListOwner myFrm = new FrmListOwner())
            {
                myFrm.ShowDialog();
            }
        }
    }
}
