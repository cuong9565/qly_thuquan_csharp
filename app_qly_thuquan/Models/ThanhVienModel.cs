using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qly_thuquan.Model
{
    internal class ThanhVienModel
    {
        private static ThanhVienModel instance = null;
        private ThanhVienModel() { }
        public static ThanhVienModel getInstance()
        {
            if (instance == null) instance = new ThanhVienModel();
            return instance;
        }
        public DataTable getAll()
        {
            try
            {
                string sql =
                    "select tv.id as 'Mã số', tv.lName as 'Họ', tv.fName as 'Tên', dateCreate as 'Ngày đăng ký', email as 'Email', phone as 'Số điện thoại', password as 'Mật khẩu'" +
                    "from thanh_vien tv";
                return DataProvider.getInstance().ExecuteQuery(sql);
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
                string sql =
                    "select * " +
                    "from thanh_vien " +
                    "where id = @id";
                DataTable dt = DataProvider.getInstance().ExecuteQuery(sql, new object[] {id});
                foreach (DataRow row in dt.Rows)
                    tv = new ThanhVien(row);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return tv;
        }
        public bool checkSame(string id)
        {
            string sql =
                    "select * " +
                    "from thanh_vien " +
                    "where id = @id";
            DataTable dt = DataProvider.getInstance().ExecuteQuery(sql, new object[] { id });
            return dt.Rows.Count > 0;
        }
        public void insert(string id, string lName, string fName, string email, string phone)
        {
            try
            {
                string sql =
                    "insert into thanh_vien(id, lName, fName, email, phone) " +
                    "values( @id , @fName , @lName , @email , @pphone )";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { id, lName, fName, email, phone });
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
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { lName, fName, email, phone, id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void delete(string id)
        {
            try
            {
                string sql =
                    "delete from thanh_vien " +
                    "where id = @id";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int deleteByYear(int year)
        {
            int res = 0;
            try
            {
                string sql =
                    "delete from thanh_vien " +
                    "where year(dateCreate) = @dateCreate";
                res = DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { year });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return res;
        }
    }
}
