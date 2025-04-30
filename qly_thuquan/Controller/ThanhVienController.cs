using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qly_thuquan.Model;

namespace qly_thuquan.Controller
{
    internal class ThanhVienController
    {
        private static ThanhVienController instance = null;
        private ThanhVienController() { }
        public static ThanhVienController getInstance()
        {
            if (instance == null) instance = new ThanhVienController();
            return instance;
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = ThanhVienModel.getInstance().getAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public ThanhVien getById(int id)
        {
            ThanhVien tv = new ThanhVien();
            try
            {
                tv = ThanhVienModel.getInstance().getById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tv;
        }
        public void insert(string fName, string lName, string email, string phone)
        {
            try
            {
                if (fName == "") throw new Exception("Họ không được để trống!");
                if (lName == "") throw new Exception("Tên không được để trống!");
                if (email == "") throw new Exception("Email không được để trống!");
                if (phone == "") throw new Exception("Số điện thoại không được để trống!");
                if (ThanhVienModel.getInstance().checkSame(phone)) throw new Exception($"Số điện thoại {phone} đã tồn tại!");
                ThanhVienModel.getInstance().insert(fName, lName, email, phone);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void update(int id, string fName, string lName, string email, string phone)
        {
            try
            {
                if (fName == "") throw new Exception("Họ không được để trống!");
                if (lName == "") throw new Exception("Tên không được để trống!");
                if (email == "") throw new Exception("Email không được để trống!");
                if (phone == "") throw new Exception("Số điện thoại không được để trống!");

                ThanhVien curr = ThanhVienModel.getInstance().getById(id);
                if (ThanhVienModel.getInstance().checkSame(phone) && curr.GetPhone()!=phone) 
                    throw new Exception($"Số điện thoại {phone} đã tồn tại!");

                ThanhVienModel.getInstance().update(id, fName, lName, email, phone);
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
                ThanhVienModel.getInstance().delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int deleteByYear(int year)
        {
            int res = 0;
            try
            {
                res = ThanhVienModel.getInstance().deleteByYear(year);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;
        }
    }
}
