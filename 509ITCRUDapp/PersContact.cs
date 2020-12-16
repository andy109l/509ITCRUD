using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _509ITCRUDapp
{
    /// <summary>
    /// Properties in this class are assigned the data from the database during the getAllPersonal method
    /// </summary>
    public class PersContact :Contact
    {
        public string phone_number { get; set; }
    }
}
