using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _509ITCRUDapp
{
    public partial class PersContactCRUD : Form
    {

        DbConn dbConn = new DbConn(); 


        public PersContactCRUD()
        {
            InitializeComponent();
        }

        private void PersContactCRUD_Load(object sender, EventArgs e)
        {
            dgvPers.DataSource = dbConn.getAllPersonal();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPers.DataSource = dbConn.getAllPersonal();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbFirstNamePers.Enabled = true;
            tbLastNamePers.Enabled = true;
            tbEmailPers.Enabled = true;
            tbPhonePers.Enabled = true;
            tbAddressLine1Pers.Enabled = true;
            tbAddressLine2Pers.Enabled = true;
            tbPostcodePers.Enabled = true;
            tbCountryPers.Enabled = true;
            btnUpdateSel.Enabled = false;
            btnDeleteSel.Enabled = false;
            btnSaveNew.Enabled = true;
            tbFirstNamePers.Text = String.Empty;
            tbLastNamePers.Text = String.Empty;
            tbEmailPers.Text = String.Empty;
            tbPhonePers.Text = String.Empty;
            tbAddressLine1Pers.Text = String.Empty;
            tbAddressLine2Pers.Text = String.Empty;
            tbPostcodePers.Text = String.Empty;
            tbCountryPers.Text = String.Empty;


        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            PersContact personalContact = new PersContact();
            personalContact.first_name = tbFirstNamePers.Text;
            personalContact.last_name = tbLastNamePers.Text;
            personalContact.email = tbEmailPers.Text;
            personalContact.phone_number = tbPhonePers.Text;
            personalContact.address_line_1 = tbAddressLine1Pers.Text;
            personalContact.address_line_2 = tbAddressLine2Pers.Text;
            personalContact.postcode= tbPostcodePers.Text;
            personalContact.country = tbCountryPers.Text;
            dbConn.InsertPersoanl(personalContact);
            tbFirstNamePers.Enabled = false;
            tbLastNamePers.Enabled = false;
            tbEmailPers.Enabled = false;
            tbPhonePers.Enabled = false;
            tbAddressLine1Pers.Enabled = false;
            tbAddressLine2Pers.Enabled = false;
            tbPostcodePers.Enabled = false;
            tbCountryPers.Enabled = false;
            btnUpdateSel.Enabled = true;
            btnDeleteSel.Enabled = true;
            btnSaveNew.Enabled = false;
        }

        private void dgvPers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indx = Int32.Parse(dgvPers.SelectedCells[0].Value.ToString());
            tbFirstNamePers.Text = dgvPers.SelectedCells[1].Value.ToString();
            tbLastNamePers.Text = dgvPers.SelectedCells[2].Value.ToString();
            tbEmailPers.Text = dgvPers.SelectedCells[3].Value.ToString();
            tbPhonePers.Text = dgvPers.SelectedCells[4].Value.ToString();
            tbAddressLine1Pers.Text = dgvPers.SelectedCells[5].Value.ToString();
            tbAddressLine2Pers.Text = dgvPers.SelectedCells[6].Value.ToString();
            tbPostcodePers.Text = dgvPers.SelectedCells[7].Value.ToString();
            tbCountryPers.Text = dgvPers.SelectedCells[8].Value.ToString();
        }
    }
}
