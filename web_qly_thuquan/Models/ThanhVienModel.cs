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
        public ThanhVien Login(string phone, string password)
        {
            ThanhVien tv = new ThanhVien();
            try
            {
                string sql =
                    "select * from thanh_vien " +
                    "where phone = @phone and password = @password";
                DataTable dt = DataProvider.GetInstance().ExecuteQuery(sql, new object[] {phone, password});
                foreach (DataRow dr in dt.Rows)
                    tv = new ThanhVien(dr);
            }
            catch (Exception ex) { 
                throw new Exception(ex.Message);
            }
            return tv;
        }
    }
}