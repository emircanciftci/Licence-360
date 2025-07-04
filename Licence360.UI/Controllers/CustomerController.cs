using Licence360.DAL.DB;
using Licence360.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Licence360.UI.Controllers
{
    public class CustomerController : BaseController
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View(service.CustomerService.GetAll());
        }
        public ActionResult Insert()
        {
            return View();
        }
        public ActionResult Insertt(Customer cus)
        {
            service.CustomerService.Insert(cus);
            return Json(true,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult InsertCustomerProduct(CustomerLicence cl)
        {
            service.CustomerLicenceService.Insert(cl);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        //[HttpPost] => JsonRequestBehavior ile get isteği yapılmış ama controllerda httppost işaretlenmiş hatalı !
        public JsonResult UpdateModal(int ID)
        {
            var result = service.CustomerService.GetAll().Where(x => x.ID == ID).FirstOrDefault();
            //tabloyu direkt gönderemeyiz ilişkili tablolarda sadce ihtiyacın olan datayı model doldurup göndermen gerekiyor
            if (result != null)
            {
                CustomerVM vm = new CustomerVM()
                {
                    ID = result.ID,
                    companyName = result.CompanyName,
                    authPerson = result.AuthPerson,
                    email = result.Email,
                    phone = result.Phone,
                    address = result.Address
                };
                return Json(vm, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult CustomerUpdate(Customer dat)
        {
            service.CustomerService.Update(dat);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Detail(int ID)
        {
            return View(service.CustomerLicenceService.GetAll().Where(x => x.CustomerID == ID).ToList());

        }
        public JsonResult UpdateIsActive(int ID)
        {
            var result = service.CustomerService.UpdateIsActive(ID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}