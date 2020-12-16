using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _509ITCRUDapp
{
    /// <summary>
    /// Properties in this class are assigned the data from the database during the getAllBusiness method
    /// </summary>
    public class BusiContact : Contact
    {
        public string company { get; set; }
        public string business_phone_number { get; set; }
    }
}
