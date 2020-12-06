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
    public partial class ContactMainMenu : Form
    {
        public ContactMainMenu()
        {
            InitializeComponent();
        }

        private void btn_pers_contacts_click(object sender, EventArgs e)
        {
            PersContactCRUD personalEditor = new PersContactCRUD();
            personalEditor.Show();
        }

        private void btn_busi_contacts_click(object sender, EventArgs e)
        {
            BusiContactCRUD businessEditor = new BusiContactCRUD();
            businessEditor.Show();
        }
    }
}
