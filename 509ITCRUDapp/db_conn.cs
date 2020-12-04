using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace _509ITCRUDapp
{
     public class db_conn
    {
        private string connString = "Server=localhost;User ID=root ;Password=; Database=509itcrudsys";

        public DataTable GetAllPersonal()
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                DataTable personal_contact_dt = new DataTable();
                List<pers_contact> pers_contacts = new List<pers_contact>();
            }
        }
    }
}
