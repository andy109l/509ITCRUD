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
        /// <summary>
        /// on load populates the dgvPers with data retrieved from the database using the method getAllPersonal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersContactCRUD_Load(object sender, EventArgs e)
        {
            dgvPers.DataSource = dbConn.getAllPersonal();
        }
        /// <summary>
        /// on click populates/updates the dgvPers with data retrieved from the database using the method getAllPersonal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPers.DataSource = dbConn.getAllPersonal();
        }
        /// <summary>
        /// on click toggles all the required buttons and text boxes used to add new personal contact, resets the text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            btnAddNew.Enabled = false;
            tbFirstNamePers.Text = String.Empty;
            tbLastNamePers.Text = String.Empty;
            tbEmailPers.Text = String.Empty;
            tbPhonePers.Text = String.Empty;
            tbAddressLine1Pers.Text = String.Empty;
            tbAddressLine2Pers.Text = String.Empty;
            tbPostcodePers.Text = String.Empty;
            tbCountryPers.Text = String.Empty;


        }
        /// <summary>
        /// on click toggles all the required buttons and text boxes used to save new personal contact, resets the text boxes
        /// saves contacts in the database
        /// reloads the data in the dgvPers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            btnAddNew.Enabled = true;
            btnSaveNew.Enabled = false;

            dgvPers.DataSource = dbConn.getAllPersonal();
        }
        /// <summary>
        /// on click populates the text boxes with the data from selected dgvPers row 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// on click toggles all the required buttons and text boxes used to update selected personal contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateSel_Click(object sender, EventArgs e)
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
            btnDeleteSel.Enabled = true;
            btnSaveSel.Enabled = true;
            btnAddNew.Enabled = false;

        }
        /// <summary>
        /// on click toggles all the required buttons and text boxes used to save selected personal contact
        /// saves the updated contacts in the database
        /// reloads the data in the dgvPers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveSel_Click(object sender, EventArgs e)
        {
            int indx = Int32.Parse(dgvPers.SelectedCells[0].Value.ToString());
            PersContact personalContact = new PersContact();
            personalContact.id = indx;
            personalContact.first_name = tbFirstNamePers.Text;
            personalContact.last_name = tbLastNamePers.Text;
            personalContact.email = tbEmailPers.Text;
            personalContact.phone_number = tbPhonePers.Text;
            personalContact.address_line_1 = tbAddressLine1Pers.Text;
            personalContact.address_line_2 = tbAddressLine2Pers.Text;
            personalContact.postcode = tbPostcodePers.Text;
            personalContact.country = tbCountryPers.Text;

            dbConn.UpdatePersonal(personalContact);
            dgvPers.DataSource = dbConn.getAllPersonal();

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
            btnAddNew.Enabled = true;
            btnSaveSel.Enabled = false;  


        }
        /// <summary>
        /// on click displays a pop-up to confirm, if selected contact should be deleted
        /// if confirmed deletes selected personal contact
        /// reloads the data in the dgvPers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteSel_Click(object sender, EventArgs e)
        {
            string message = "Are you certain you want to DELETE this contact?";
            string caption = "Do you want to DELETE the contact with ID of " + Int32.Parse(dgvPers.SelectedCells[0].Value.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult outcome;

            outcome = MessageBox.Show(message, caption, buttons);
            if (outcome == DialogResult.Yes)
            {
                dbConn.DeletePersonal(Int32.Parse(dgvPers.SelectedCells[0].Value.ToString()));

                dgvPers.DataSource = dbConn.getAllPersonal();
            }
        }
    }
}
