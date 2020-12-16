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
    public partial class BusiContactCRUD : Form
    {
        DbConn dbConn = new DbConn();

        public BusiContactCRUD()
        {
            InitializeComponent();
        }
        /// <summary>
        /// on load populates the dgvBusi with data retrieved from the database using the method getAllBusiness
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BusiContactCRUD_Load(object sender, EventArgs e)
        {
            dgvBusi.DataSource = dbConn.getAllBusiness();
        }
        /// <summary>
        /// on click populates/updates the dgvBusi with data retrieved from the database using the method getAllBusiness
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefreshBusi_Click(object sender, EventArgs e)
        {
            dgvBusi.DataSource = dbConn.getAllBusiness();
        }
        /// <summary>
        /// on click toggles all the required buttons and text boxes used to add new business contact, resets the text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewBusi_Click(object sender, EventArgs e)
        {
            tbFirstNameBusi.Enabled = true;
            tbLastNameBusi.Enabled = true;
            tbEmailBusi.Enabled = true;
            tbPhoneBusi.Enabled = true;
            tbAddressLine1Busi.Enabled = true;
            tbAddressLine2Busi.Enabled = true;
            tbPostcodeBusi.Enabled = true;
            tbCountryBusi.Enabled = true;
            tbCompanyBusi.Enabled = true;
            btnUpdateSelBusi.Enabled = false;
            btnDeleteSelBusi.Enabled = false;
            btnSaveNewBusi.Enabled = true;
            btnAddNewBusi.Enabled = false;
            tbFirstNameBusi.Text = String.Empty;
            tbLastNameBusi.Text = String.Empty;
            tbEmailBusi.Text = String.Empty;
            tbPhoneBusi.Text = String.Empty;
            tbAddressLine1Busi.Text = String.Empty;
            tbAddressLine2Busi.Text = String.Empty;
            tbPostcodeBusi.Text = String.Empty;
            tbCountryBusi.Text = String.Empty;
            tbCompanyBusi.Text = String.Empty;
        }
        /// <summary>
        /// on click toggles all the required buttons and text boxes used to save new business contact, resets the text boxes
        /// saves contacts in the database
        /// reloads the data in the dgvBusi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveNewBusi_Click(object sender, EventArgs e)
        {
            BusiContact businessContact = new BusiContact();
            businessContact.first_name = tbFirstNameBusi.Text;
            businessContact.last_name = tbLastNameBusi.Text;
            businessContact.email = tbEmailBusi.Text;
            businessContact.business_phone_number = tbPhoneBusi.Text;
            businessContact.address_line_1 = tbAddressLine1Busi.Text;
            businessContact.address_line_2 = tbAddressLine2Busi.Text;
            businessContact.postcode = tbPostcodeBusi.Text;
            businessContact.country = tbCountryBusi.Text;
            businessContact.company = tbCompanyBusi.Text;

            dbConn.InsertBusiness(businessContact);

            tbFirstNameBusi.Enabled = false;
            tbLastNameBusi.Enabled = false;
            tbEmailBusi.Enabled = false;
            tbPhoneBusi.Enabled = false;
            tbAddressLine1Busi.Enabled = false;
            tbAddressLine2Busi.Enabled = false;
            tbPostcodeBusi.Enabled = false;
            tbCountryBusi.Enabled = false;
            tbCompanyBusi.Enabled = false;
            btnUpdateSelBusi.Enabled = true;
            btnDeleteSelBusi.Enabled = true;
            btnAddNewBusi.Enabled = true;
            btnSaveNewBusi.Enabled = false;

            dgvBusi.DataSource = dbConn.getAllBusiness();
        }
        /// <summary>
        ///  on click populates the text boxes with the data from selected dgvBusi row 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBusi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indx = Int32.Parse(dgvBusi.SelectedCells[0].Value.ToString());
            tbFirstNameBusi.Text = dgvBusi.SelectedCells[1].Value.ToString();
            tbLastNameBusi.Text = dgvBusi.SelectedCells[2].Value.ToString();
            tbEmailBusi.Text = dgvBusi.SelectedCells[3].Value.ToString();
            tbPhoneBusi.Text = dgvBusi.SelectedCells[4].Value.ToString();
            tbAddressLine1Busi.Text = dgvBusi.SelectedCells[5].Value.ToString();
            tbAddressLine2Busi.Text = dgvBusi.SelectedCells[6].Value.ToString();
            tbPostcodeBusi.Text = dgvBusi.SelectedCells[7].Value.ToString();
            tbCountryBusi.Text = dgvBusi.SelectedCells[8].Value.ToString();
            tbCompanyBusi.Text = dgvBusi.SelectedCells[9].Value.ToString();
        }
        /// <summary>
        /// on click toggles all the required buttons and text boxes used to update selected business contact,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateSelBusi_Click(object sender, EventArgs e)
        {
            tbFirstNameBusi.Enabled = true;
            tbLastNameBusi.Enabled = true;
            tbEmailBusi.Enabled = true;
            tbPhoneBusi.Enabled = true;
            tbAddressLine1Busi.Enabled = true;
            tbAddressLine2Busi.Enabled = true;
            tbPostcodeBusi.Enabled = true;
            tbCountryBusi.Enabled = true;
            tbCompanyBusi.Enabled = true;
            btnUpdateSelBusi.Enabled = false;
            btnDeleteSelBusi.Enabled = true;
            btnSaveSelBusi.Enabled = true;
            btnAddNewBusi.Enabled = false;
        }
        /// <summary>
        /// on click toggles all the required buttons and text boxes used to save selected business contact
        /// saves the updated contacts in the database
        /// reloads the data in the dgvBusi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveSelBusi_Click(object sender, EventArgs e)
        {
            int indx = Int32.Parse(dgvBusi.SelectedCells[0].Value.ToString());
            BusiContact businessContact = new BusiContact();
            businessContact.id = indx;
            businessContact.first_name = tbFirstNameBusi.Text;
            businessContact.last_name = tbLastNameBusi.Text;
            businessContact.email = tbEmailBusi.Text;
            businessContact.business_phone_number = tbPhoneBusi.Text;
            businessContact.address_line_1 = tbAddressLine1Busi.Text;
            businessContact.address_line_2 = tbAddressLine2Busi.Text;
            businessContact.postcode = tbPostcodeBusi.Text;
            businessContact.country = tbCountryBusi.Text;
            businessContact.company = tbCompanyBusi.Text;

            dbConn.UpdateBusiness(businessContact);
            dgvBusi.DataSource = dbConn.getAllBusiness();

            tbFirstNameBusi.Enabled = false;
            tbLastNameBusi.Enabled = false;
            tbEmailBusi.Enabled = false;
            tbPhoneBusi.Enabled = false;
            tbAddressLine1Busi.Enabled = false;
            tbAddressLine2Busi.Enabled = false;
            tbPostcodeBusi.Enabled = false;
            tbCountryBusi.Enabled = false;
            tbCompanyBusi.Enabled = false;
            btnUpdateSelBusi.Enabled = true;
            btnDeleteSelBusi.Enabled = true;
            btnAddNewBusi.Enabled = true;
            btnSaveSelBusi.Enabled = false;
        }
        /// <summary>
        /// on click displays a pop-up to confirm, if selected contact should be deleted
        /// if confirmed deletes selected business contact
        /// reloads the data in the dgvBusi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteSelBusi_Click(object sender, EventArgs e)
        {
            string message = "Are you certain you want to DELETE this contact?";
            string caption = "Do you want to DELETE the contact with ID of ?" + Int32.Parse(dgvBusi.SelectedCells[0].Value.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult outcome;

            outcome = MessageBox.Show(message, caption, buttons);
            if (outcome == DialogResult.Yes)
            {
                dbConn.DeleteBusiness(Int32.Parse(dgvBusi.SelectedCells[0].Value.ToString()));

                dgvBusi.DataSource = dbConn.getAllPersonal();
            }
        }
    }
}
