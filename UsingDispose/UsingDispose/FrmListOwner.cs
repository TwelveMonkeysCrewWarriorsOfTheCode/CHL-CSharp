using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace UsingDispose
{
    public partial class FrmListOwner : Form
    {
        public FrmListOwner()
        {
            InitializeComponent();
        }

        private void FrmListOwner_Load(object sender, EventArgs e)
        {
            //List<DTO.BankAccountDTO> ownersList = BankBLL.GetOwnersList();
            IEnumerable<DTO.BankAccountDTO> ownersList = BankBLL.GetOwnersList();
            foreach(var item in ownersList)
            {
                //    LstVwOwners.CheckBoxes = true;
                //LstVwOwners.
                //    LstOwner.Items.Add(item.OwnerName);
                //    LstVwOwners.Items.Add(item.OwnerName);
                //    LstVwOwners.Items.Add(item.Gender);
                ListViewItem lvi =
                LstVwOwners.Items.Add(item.OwnerName);
                lvi.SubItems.Add(item.Gender.ToString());
                lvi.SubItems.Add(item.Type.ToString());
            }
            LstOwner.DataSource = ownersList;

        }   
    }
}
