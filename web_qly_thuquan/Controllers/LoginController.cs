using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_qly_thuquan.Models;

namespace web_qly_thuquan.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult IsValidUser(string phone, string password)
        {
            ThanhVien tv = ThanhVienModel.getInstance().Login(phone, password);
            return Json(tv.GetId()!=0, JsonRequestBehavior.AllowGet);
        }
    }
}