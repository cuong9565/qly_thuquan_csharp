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
        public List<ThanhVien> getAllListByYear(int year)
        {
            List<ThanhVien> tv = new List<ThanhVien>();
            try
            {
                tv = ThanhVienModel.getInstance().getAllListByYear(year);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tv;
        }
        public DataTable getDTById(string id)
        {
            try
            {
                return ThanhVienModel.getInstance().getDTById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public ThanhVien getById(string id)
        {
            ThanhVien tv = new ThanhVien();
            try
            {
                tv = ThanhVienModel.getInstance().getById(id);
                if (tv.GetId() == "") throw new Exception("Không phải thành viên!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tv;
        }
        public void insert(string id, string lName, string fName, string email, string phone)
        {
            try
            {
                if (id == "") throw new Exception("Mã số không được để trống!");
                if (lName == "") throw new Exception("Họ không được để trống!");
                if (fName == "") throw new Exception("Tên không được để trống!");
                if (email == "") throw new Exception("Email không được để trống!");
                if (phone == "") throw new Exception("Số điện thoại không được để trống!");
                if (ThanhVienModel.getInstance().checkSame(id)) throw new Exception($"Mã số '{id}' đã tồn tại!");
                ThanhVienModel.getInstance().insert(id, lName, fName, email, phone);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void update(string id, string lName, string fName, string email, string phone)
        {
            try
            {
                if (lName == "") throw new Exception("Họ không được để trống!");
                if (fName == "") throw new Exception("Tên không được để trống!");
                if (email == "") throw new Exception("Email không được để trống!");
                if (phone == "") throw new Exception("Số điện thoại không được để trống!");
                ThanhVienModel.getInstance().update(id, lName, fName, email, phone);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void delete(string id)
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
        public void resetPassword(string id)
        {
            try
            {
                ThanhVienModel.getInstance().resetPassword(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int NumTV()
        {
            try
            {
                return ThanhVienModel.getInstance().NumTV();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
