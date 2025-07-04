using Licence360.DAL.DB;
using Licence360.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Licence360.UI.Controllers
{
    public class LicenceController : BaseController
    {
        // GET: Licence
        public ActionResult Index()
        {
            return View(service.CustomerLicenceService.GetAll().ToList());
        }
        public ActionResult Insert()
        {
            LicenceVM vm = new LicenceVM();
            vm.CustomerList = service.CustomerService.GetAll().Where(x => x.IsActive == true).ToList();
            vm.ProductList = service.ProductService.GetAll().Where(x => x.IsActive == true).ToList();
            vm.TimeList = service.LicenceTimeService.GetAll();
            return View(vm);
        }
        public JsonResult UpdateIsActive(int ID)
        {
            var result = service.CustomerLicenceService.UpdateIsActive(ID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}