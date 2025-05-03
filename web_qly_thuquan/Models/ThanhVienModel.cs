using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace web_qly_thuquan.Models
{
    public class ThanhVienModel
    {
        private static ThanhVienModel instance = null;
        private ThanhVienModel() { }
        public static ThanhVienModel getInstance()
        {
            if (instance == null) instance = new ThanhVienModel();
            return instance;
        }
        public void Login(string id, string password)
        {
            ThanhVien tv = new ThanhVien();
            try
            {
                string sql =
                    "select * from thanh_vien " +
                    "where id = @id and password = @password";
                DataTable dt = DataProvider.GetInstance().ExecuteQuery(sql, new object[] { id, password });
                if (dt.Rows.Count == 0) throw new Exception("Mã số hoặc mật khẩu không hợp lệ!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool checkSame(string id)
        {
            string sql =
                    "select * " +
                    "from thanh_vien " +
                    "where id = @id";
            DataTable dt = DataProvider.GetInstance().ExecuteQuery(sql, new object[] { id });
            return dt.Rows.Count > 0;
        }
        public ThanhVien getById(string id)
        {
            ThanhVien tv = new ThanhVien();
            try
            {
                string sql =
                    "select * " +
                    "from thanh_vien " +
                    "where id = @id";
                DataTable dt = DataProvider.GetInstance().ExecuteQuery(sql, new object[] { id });

                if (dt.Rows.Count > 0) tv = new ThanhVien(dt.Rows[0]);
                else throw new Exception($"Không phải thành viên");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return tv;
        }
        public void insert(string id, string lName, string fName, string email, string phone, string password)
        {
            try
            {
                string sql =
                    "insert into thanh_vien(id, lName, fName, email, phone, password) " +
                    "values( @id , @fName , @lName , @email , @pphone , @password )";
                DataProvider.GetInstance().ExecuteNonQuery(sql, new object[] { id, lName, fName, email, phone, password });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void update(string id, string lName, string fName, string email, string phone)
        {
            try
            {
                string sql =
                    "update thanh_vien set lName = @lName , fName = @fName , email = @email , phone = @phone " +
                    "where id = @id";
                DataProvider.GetInstance().ExecuteNonQuery(sql, new object[] { lName, fName, email, phone, id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void checkTruePassword(string id, string password)
        {
            try
            {
                string sql =
                    "select * from thanh_vien " +
                    "where id = @id and password = @password";
                DataTable dt = DataProvider.GetInstance().ExecuteQuery(sql, new object[] { id, password});
                if (dt.Rows.Count == 0) throw new Exception("Mật khẩu hiện tại không hợp lệ!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void updatePassword(string id, string password)
        {
            try
            {
                string sql =
                    "update thanh_vien " +
                    "set password = @password " +
                    "where id = @id";
                DataProvider.GetInstance().ExecuteNonQuery(sql, new object[] { password, id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}