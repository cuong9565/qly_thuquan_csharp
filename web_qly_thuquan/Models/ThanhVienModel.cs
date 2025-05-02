using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

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
        public ThanhVien Login(string id, string password)
        {
            ThanhVien tv = new ThanhVien();
            try
            {
                string sql =
                    "select * from thanh_vien " +
                    "where id = @id and password = @password";
                DataTable dt = DataProvider.GetInstance().ExecuteQuery(sql, new object[] {id, password});
                foreach (DataRow dr in dt.Rows)
                    tv = new ThanhVien(dr);
            }
            catch (Exception ex) { 
                throw new Exception(ex.Message);
            }
            return tv;
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
    }
}