using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace web_qly_thuquan.Models
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            Session.Clear();
            return View();
        }

        [HttpPost]
        public JsonResult RegisterTV(string id, string lName, string fName, string email, string phone, string pw, string confirmPw, bool ck)
        {
            try
            {
                if (id == "") return Json(new { success = false, error = "Mã số không được để trống!" });
                if (lName == "") return Json(new { success = false, error = "Họ không được để trống!" });
                if (fName == "") return Json(new { success = false, error = "Tên không được để trống!" });
                if (email == "") return Json(new { success = false, error = "Email không được để trống!" });
                if (phone == "") return Json(new { success = false, error = "Số điện thoại không được để trống!" });
                if (pw == "") return Json(new { success = false, error = "Mật khẩu không được để trống!" });
                if (confirmPw == "") return Json(new { success = false, error = "Mật khẩu xác nhận không được để trống!" });
                if (pw != confirmPw) return Json(new { success = false, error = "Mật khẩu và mật khẩu xác nhận không khớp nhau!" });
                if (!ck) return Json(new { success = false, error = "Bạn chưa chấp nhận điều khoản!" });
                
                if (ThanhVienModel.getInstance().checkSame(id)) return Json(new { success = false, error = $"Mã số '{id}' đã tồn tại!" });
                
                ThanhVienModel.getInstance().insert(id, lName, fName, email, phone, pw);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }

            return Json(new { success = true });
        }
    }
}