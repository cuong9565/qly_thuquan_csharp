using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_qly_thuquan.Models;

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

        [HttpPost]
        public JsonResult LoadTaiKhoan()
        {
            ThanhVien tv = new ThanhVien();
            try
            {
                string id = (string) Session["UserId"];
                tv = ThanhVienModel.getInstance().getById(id);
            }
            catch (Exception ex) { 
                return Json(new {success = false, error = ex.Message});
            }
            return Json(new { success = true , thanhvien = tv});
        }

        [HttpPost]
        public JsonResult UpdateTaiKhoan(string lName, string fName, string email, string phone)
        {
            try
            {
                string id = (string)Session["UserId"];
                if (lName == "") return Json(new { success = false, error = "Họ không được để trống!" });
                if (fName == "") return Json(new { success = false, error = "Tên không được để trống!" });
                if (email == "") return Json(new { success = false, error = "Email không được để trống!" });
                if (phone == "") return Json(new { success = false, error = "Số điện thoại không được để trống!" });
                
                ThanhVienModel.getInstance().update(id, lName, fName, email, phone);
            }
            catch (Exception e) {
                return Json(new {success = false, error = e.Message});
            }
            return Json(new { success = true });
        }

        [HttpPost]
        public JsonResult UpdatePassword(string currPW, string newPW, string confirmPW) {
            try
            {
                string id = (string)Session["UserId"];
                if (currPW == "") return Json(new { success = false, error = "Mật khẩu hiện tại không được để trống!" });
                if (newPW == "") return Json(new { success = false, error = "Mật khẩu mới không được để trống!" });
                if (confirmPW == "") return Json(new { success = false, error = "Mật khẩu xác nhận không được để trống!" });
                if(newPW != confirmPW) return Json(new { success = false, error = "Mật khẩu mới và mật khẩu xác nhận không trùng khớp!" });
                ThanhVienModel.getInstance().checkTruePassword(id, currPW);
                ThanhVienModel.getInstance().updatePassword(id, newPW);
            }
            catch (Exception e) {
                return Json(new { success = false, error = e.Message });
            }
            return Json(new { success = true });
        }

    }
}