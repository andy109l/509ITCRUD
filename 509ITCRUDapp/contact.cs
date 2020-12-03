using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _509ITCRUDapp
{
    public abstract class contact
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
    }
}
