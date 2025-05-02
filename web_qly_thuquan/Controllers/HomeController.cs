using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_qly_thuquan.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session["UserId"] == null) return RedirectToAction("Index", "Login");
            return View();
        }
        public ActionResult DatCho()
        {
            if (Session["UserId"] == null) return RedirectToAction("Index", "Login");
            return View();
        }
        public ActionResult LichSu()
        {
            if (Session["UserId"] == null) return RedirectToAction("Index", "Login");
            return View();
        }
        public ActionResult TaiKhoan()
        {
            if (Session["UserId"] == null) return RedirectToAction("Index", "Login");
            return View();
        }
        public ActionResult DoiMatKhau()
        {
            if (Session["UserId"] == null) return RedirectToAction("Index", "Login");
            return View();
        }
    }
}