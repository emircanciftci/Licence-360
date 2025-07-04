using Licence360.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Licence360.UI.Controllers
{
    public class SetupController : BaseController
    {
        // GET: Setup
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InsertLicenceTime()
        {
            return View(service.LicenceTimeService.GetAll());
        }
        [HttpPost]
        public JsonResult InsertLicenceT(LicenceTime LTN)
        {
            service.LicenceTimeService.Insert(LTN);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Admin()
        {
            return View(service.AdminUserService.GetAll());
        }
    }
}