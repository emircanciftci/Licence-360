using Licence360.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Licence360.UI.Models
{
    public class LicenceVM
    {
        public int ID { get; set; }
        public int productNameID { get; set; }
        public int customerNameID { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string customerURL { get; set; }

        public List<Customer> CustomerList { get; set; }
        public List<Product> ProductList { get; set; }
        public List<LicenceTime> TimeList { get; set; }
    }
}