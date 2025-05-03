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
            Session.Clear();
            return View();
        }
        [HttpPost]
        public JsonResult IsValidUser(string id, string password)
        {
            try
            {
                if (id == "") return Json(new { success = false, error = "Mã số không được để trống!" });
                ThanhVienModel.getInstance().Login(id, password);
                Session["UserId"] = id;
            }
            catch (Exception ex) 
            {
                return Json(new { success = false, error = ex.Message });
            }
            return Json(new { success = true });
        }
    }
}