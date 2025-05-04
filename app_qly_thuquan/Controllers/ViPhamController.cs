using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qly_thuquan.Controllers;
using qly_thuquan.Model;
using qly_thuquan.Models;

namespace qly_thuquan.Controllers
{
    public class ViPhamController
    {
        private static ViPhamController instance = null;
        public static ViPhamController getInstance()
        {
            if (instance == null) instance = new ViPhamController();
            return instance;
        }
        public DataTable loadByIdTV(string idTV)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = ViPhamModel.getInstance().loadByIdTV(idTV);
            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
            return dt;
        }
        public void insert(string idTV, string name, double price)
        {
            try
            {
                ViPhamModel.getInstance().insert(idTV, name, price);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void update(int id, string name, double price, string state, DateTime dateCreate)
        {
            try
            {
                DateTime currDate = DateTime.Now;
                if (name == "Khóa thẻ vĩnh viễn" && state == "Đã xử lý")
                    throw new Exception("Thẻ đang bị khóa vĩnh viễn! Không thể xử lý");
                else if(name == "Khóa thẻ 1 tháng" && state == "Đã xử lý")
                {
                    currDate = currDate.AddMonths(-1);
                    if(dateCreate > currDate)
                        throw new Exception("Chưa đủ 1 tháng! Không thể xử lý");
                }
                else if(name == "Khóa thẻ 2 tháng" && state == "Đã xử lý")
                {
                    currDate = currDate.AddMonths(-2);
                    if (dateCreate > currDate)
                        throw new Exception("Chưa đủ 2 tháng! Không thể xử lý");
                }
                ViPhamModel.getInstance().update(id, name, price, state);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void delete(int id)
        {
            try
            {
                ViPhamModel.getInstance().delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void XuLy(int id, string name, string state, DateTime dateCreate)
        {
            try
            {
                DateTime currDate = DateTime.Now;
                if (name == "Khóa thẻ vĩnh viễn" && state == "Đã xử lý")
                    throw new Exception("Thẻ đang bị khóa vĩnh viễn! Không thể xử lý");
                else if (name == "Khóa thẻ 1 tháng" && state == "Đã xử lý")
                {
                    currDate = currDate.AddMonths(-1);
                    if (dateCreate > currDate)
                        throw new Exception("Chưa đủ 1 tháng! Không thể xử lý");
                }
                else if (name == "Khóa thẻ 2 tháng" && state == "Đã xử lý")
                {
                    currDate = currDate.AddMonths(-2);
                    if (dateCreate > currDate)
                        throw new Exception("Chưa đủ 2 tháng! Không thể xử lý");
                }
                ViPhamModel.getInstance().XuLy(id, state);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
