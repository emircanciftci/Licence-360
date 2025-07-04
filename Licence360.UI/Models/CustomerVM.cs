using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Licence360.UI.Models
{
    public class CustomerVM
    {
        public int ID { get; set; }
        public string companyName { get; set; }
        public string authPerson { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public bool ısActive { get; set; }
    }
}