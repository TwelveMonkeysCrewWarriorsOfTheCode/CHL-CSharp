using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace UsingDispose
{
    public partial class FrmCreateAccount : Form
    {
        private const int MINIMUM_NAME_LENGTH = 2;
        RadioButton selectedGenderRadioButton;
        RadioButton selectedAccountRadioButton;

        public BankAccountBLL CreatedAccount { get; private set; }

        public FrmCreateAccount()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            /*
            Gender selectedGender;
            switch (selectedGenderRadioButton.Tag)
            {
                case Gender.Male:
                    selectedGender = Gender.Male;
                    break;
                case Gender.Female:
                    selectedGender = Gender.Female;
                    break;
                default:
                    selectedGender = Gender.Unknown;
                    break;
            }*/
            /*
            Gender selectedGender = Gender.Unknown;
            if (RdbMasculin.Checked)
            {
                selectedGender = Gender.Male;
            }
            if (RdbFeminin.Checked)
            {
                selectedGender = Gender.Female;
            }*/
            /*
            Gender selectedGender;
            switch (selectedGenderRadioButton.Text.ToLower())
            {
                case "masculin":
                    selectedGender = Gender.Male;
                    break;
                case "feminin":
                    selectedGender = Gender.Female;
                    break;
                default:
                    selectedGender = Gender.Unknown;
                    break;
            }*/
            /*
            AccountType selectedAccountType;
            switch (selectedAccountRadioButton.Text.ToLower())
            {
                case "compte courant":
                    selectedAccountType = AccountType.Current;
                    break;
                default:
                    selectedAccountType = AccountType.Saving;
                    break;
            }*/
            //this.CreatedAccount = new BLL.BankAccount(TxtOwnerName.Text, selectedGender, selectedAccountType);
            this.CreatedAccount = new BLL.BankAccountBLL(TxtOwnerName.Text, (Gender)selectedGenderRadioButton.Tag, (AccountType)selectedAccountRadioButton.Tag);
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RdbGender_CheckedChanged(object sender, EventArgs e)
        {
            // Exemple avec un IS
            //if (sender is RadioButton)
            //{
            //    RadioButton rdbBis = (RadioButton)sender;
            //}
            // Exemple avec un AS (conseillé)
            RadioButton rdb = sender as RadioButton;
            if (rdb != null && rdb.Checked)
            {
                selectedGenderRadioButton = rdb;
                //MessageBox.Show(selectedGenderRadioButton.Text);
            }
            EnableBtnOK();
        }

        private void RdbAccount_CheckedChanged(object sender, EventArgs e)
        {
            // Exemple avec un AS (conseillé)
            RadioButton rdb = sender as RadioButton;
            if (rdb != null && rdb.Checked)
            {
                selectedAccountRadioButton = rdb;
                //MessageBox.Show(selectedAccountRadioButton.Text);
            }
            EnableBtnOK();
        }

        private void TxtOwnerName_TextChanged(object sender, EventArgs e)
        {
            EnableBtnOK();
        }

        private void EnableBtnOK()
        {
            // Alternative
            //BtnOK.Enabled = TxtOwnerName.Text.Trim().Length > 2 && selectedGenderRadioButton != null && selectedAccountRadioButton != null;
            if (TxtOwnerName.Text.Trim().Length > MINIMUM_NAME_LENGTH && selectedGenderRadioButton != null && selectedAccountRadioButton != null)
            {
                BtnOK.Enabled = true;
            }
            else
            {
                BtnOK.Enabled = false;
            }
        }

        private void FrmCreateAccount_Load(object sender, EventArgs e)
        {
            this.RdbMasculin.Tag = Gender.Male;
            this.RdbFeminin.Tag = Gender.Female;
            this.RdbInconnu.Tag = Gender.Unknown;
            this.RdbCurrent.Tag = AccountType.Current;
            this.RdbSaving.Tag = AccountType.Saving;
        }
    }
}
