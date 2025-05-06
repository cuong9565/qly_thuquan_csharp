using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qly_thuquan.Model
{
    internal class ThietBiModel
    {
        private static ThietBiModel instance = null;
        private ThietBiModel() { }
        public static ThietBiModel getInstance()
        {
            if (instance == null) instance = new ThietBiModel();
            return instance;
        }
        public DataTable getAll()
        {
            try
            {
                string sql =
                    "select id as 'Mã số', name as 'Tên', state as 'Trạng thái' " +
                    "from thiet_bi";
                return DataProvider.getInstance().ExecuteQuery(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public ThietBi getById(string id)
        {
            ThietBi tv = new ThietBi();
            try
            {
                string sql =
                    "select * " +
                    "from thiet_bi " +
                    "where id = @id";
                DataTable dt = DataProvider.getInstance().ExecuteQuery(sql, new object[] { id });
                foreach (DataRow row in dt.Rows)
                    tv = new ThietBi(row);
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
                "from thiet_bi " +
                "where id = @id";
            DataTable dt = DataProvider.getInstance().ExecuteQuery(sql, new object[] { id });
            return dt.Rows.Count > 0;
        }
        public void insert(string id, string name)
        {
            try
            {
                string sql =
                    "insert into thiet_bi(id, name) " +
                    "values( @id , @name )";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { id, name });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void update(string id, string name, string state)
        {
            try
            {
                string sql =
                    "update thiet_bi set name = @name , state = @state " +
                    "where id = @id";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { name, state, id });
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
                    "delete from thiet_bi " +
                    "where id = @id";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int deleteByTopId(string top)
        {
            int res;
            try
            {
                top += "%";
                string sql =
                    "delete from thiet_bi " +
                    "where id like @top";
                res = DataProvider.getInstance().ExecuteNonQuery(sql, new Object[] { top });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return res;
        }
        // Thong ke
        public int NumTB()
        {
            try
            {
                string sql =
                    "select count(*) " +
                    "from thiet_bi";
                DataTable dt = DataProvider.getInstance().ExecuteQuery(sql);
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
