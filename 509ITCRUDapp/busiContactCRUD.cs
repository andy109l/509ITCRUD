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

        private void BusiContactCRUD_Load(object sender, EventArgs e)
        {
            dgvBusi.DataSource = dbConn.getAllBusiness();
        }

        private void btnRefreshBusi_Click(object sender, EventArgs e)
        {
            dgvBusi.DataSource = dbConn.getAllBusiness();
        }
    }
}
