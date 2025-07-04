using Licence360.DAL.DB;
using Licence360.UI.Attribute;
using Licence360.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Licence360.UI.Controllers
{
    //[Auth]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {

            HomeVM vm = new HomeVM();
            vm.ProductList = service.ProductService.GetAll().ToList();
            vm.CustomerList = service.CustomerService.GetAll().ToList();
            vm.CustomerLicenceList = service.CustomerLicenceService.GetAll().ToList();
            return View(vm);
        }

        public ActionResult ActiveCustomerDetail()
        {
            return View(service.CustomerService.GetAll().Where(x => x.IsActive == true).ToList());
        }
        public ActionResult PassiveCustomerDetail()
        {
            return View(service.CustomerService.GetAll().Where(x => x.IsActive != true).ToList());
        }
        public ActionResult LicenceDetail()
        {
            var oneMonthLater = DateTime.Now.AddDays(30);
            return View(service.CustomerLicenceService.GetAll().Where(x =>x.EndDate >= DateTime.Today && x.EndDate <= oneMonthLater).ToList());
        }
    }
}