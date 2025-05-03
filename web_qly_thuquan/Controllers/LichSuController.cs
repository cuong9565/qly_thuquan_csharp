using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_qly_thuquan.Controllers
{
    public class LichSuController : Controller
    {
        // GET: LichSu
        public ActionResult Vao()
        {
            if (Session["UserId"] == null) return RedirectToAction("Index", "Login");
            return View();
        }
        public ActionResult DatCho()
        {
            if (Session["UserId"] == null) return RedirectToAction("Index", "Login");
            return View();
        }
        public ActionResult ViPham()
        {
            if (Session["UserId"] == null) return RedirectToAction("Index", "Login");
            return View();
        }
    }
}