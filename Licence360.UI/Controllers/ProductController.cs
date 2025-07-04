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
    public class ProductController : BaseController
    {
        // GET: Product
        public ActionResult Index()
        {
            return View(service.ProductService.GetAll());
        }
        public ActionResult Insert()
        {
            return View(service.LicenceTimeService.GetAll().ToList());
        }
        [HttpPost]
        public JsonResult InsertProduct(Product Pro)
        {
            service.ProductService.Insert(Pro);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateIsActive(int ID)
        {
            var result = service.ProductService.UpdateIsActive(ID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ProductDetail(int ID)
        {
            return View(service.CustomerLicenceService.GetAll().Where(x => x.ProductID == ID).ToList());
        }
    }
}