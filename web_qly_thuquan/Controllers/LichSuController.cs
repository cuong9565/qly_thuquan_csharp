using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Misc;
using Google.Protobuf.WellKnownTypes;
using web_qly_thuquan.Models;
using static Mysqlx.Datatypes.Scalar.Types;

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

        public JsonResult LoadVaoTQ(string col, string txt) {
            List<LichSuVao> ls = new List<LichSuVao>();
            try
            {
                string idTV = (string)Session["UserId"];

                foreach (LichSuVao lsv in LichSuVaoModel.getInstance().getAll())
                    if (lsv.IdTV == idTV)
                    {
                        switch (col)
                        {
                            case "Mã số": if (lsv.Id.ToString().Contains(txt)) ls.Add(lsv); break;
                            case "Thời gian": if (lsv.FomartTimeIn.Contains(txt)) ls.Add(lsv); break;
                        }
                    }
            }
            catch (Exception e)
            {
                return Json(new { success = false, error = e.Message });
            }

            return Json(new { success = true, res = ls });
        }
        public JsonResult LichSuDatCho(string col, string txt) {
            List<MuonTra> ls = new List<MuonTra>();
            try
            {
                string idTV = (string)Session["UserId"];

                foreach (MuonTra mt in MuonTraModel.getInstance().getAll())
                    if (mt.IdTV == mt.IdTV)
                    {
                        switch (col)
                        {
                            case "Mã số": if (mt.Id.ToString().Contains(txt)) ls.Add(mt); break;
                            case "Mã thiết bị": if (mt.IdTB.Contains(txt)) ls.Add(mt); break;
                            case "Thời gian đặt": if (mt.FomartedTimeBook.Contains(txt)) ls.Add(mt); break;
                            case "Thời gian mượn": if (mt.FomartedTimeBorrow.Contains(txt)) ls.Add(mt); break;
                            case "Thời gian trả": if (mt.FomartedTimeReturn.Contains(txt)) ls.Add(mt); break;
                            case "Trạng thái": if (mt.State.Contains(txt)) ls.Add(mt); break;
                        }
                    }
            }
            catch (Exception e)
            {
                return Json(new { success = false, error = e.Message });
            }

            return Json(new { success = true, res = ls });
        }
        public JsonResult LichSuViPham(string col, string txt) {
            List<ViPham> ls = new List<ViPham>();
            try
            {
                string idTV = (string)Session["UserId"];

                foreach (ViPham mt in ViPhamModel.getInstance().getAll())
                    if (idTV == mt.IdTV)
                    {
                        switch (col)
                        {
                            case "Mã số": if (mt.Id.ToString().Contains(txt)) ls.Add(mt); break;
                            case "Tên vi phạm": if (mt.Name.Contains(txt)) ls.Add(mt); break;
                            case "Bồi thường": if (mt.Price.ToString().Contains(txt)) ls.Add(mt); break;
                            case "Ngày tạo": if (mt.FormattedDateCreate.Contains(txt)) ls.Add(mt); break;
                            case "Trạng thái": if (mt.State.Contains(txt)) ls.Add(mt); break;
                        }
                    }
            }
            catch (Exception e)
            {
                return Json(new { success = false, error = e.Message });
            }

            return Json(new { success = true, res = ls });
        }
    }
}