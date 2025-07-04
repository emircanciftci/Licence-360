using Licence360.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Licence360.UI.Models
{
    public class HomeVM
    {
        public List<Product> ProductList { get; set; }
        public List<Customer> CustomerList { get; set; }
        public List<CustomerLicence> CustomerLicenceList { get; set; }
    }
}