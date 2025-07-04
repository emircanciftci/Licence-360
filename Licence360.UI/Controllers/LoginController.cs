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
    public class LoginController : BaseController
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoginCheck(LoginVM vm)
        {
            AdminUser result;

            AdminUser au = new AdminUser()
            {
                UserName = vm.username,
                Password = vm.password
            };

            result = service.AdminUserService.LoginCheck(au);

            if (result.ID != 0)
            {
                SessionContext _sessionContext = new SessionContext()
                {
                    ID = result.ID,
                    UserName = result.UserName
                };
                Session["SessionContext"] = _sessionContext;
            }

            else
            {
                result = new AdminUser();
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            Session.Abandon();
            return Redirect("/Login/Index");
        }
    }
}