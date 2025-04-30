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
                String sql =
                    "select id as 'Mã số', name as 'Tên', state as 'Trạng thái' " +
                    "from thiet_bi";
                return DataProvider.getInstance().ExecuteQuery(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public ThietBi getById(int id)
        {
            ThietBi tv = new ThietBi();
            try
            {
                String sql =
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
        public bool checkSame(string name)
        {
            String sql =
                "select * " +
                "from thiet_bi " +
                "where name = @name";
            DataTable dt = DataProvider.getInstance().ExecuteQuery(sql, new object[] { name });
            return dt.Rows.Count > 0;
        }
        public void insert(string name)
        {
            try
            {
                String sql =
                    "insert into thiet_bi(name) " +
                    "values( @name )";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { name });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void update(int id, string name, string state)
        {
            try
            {
                String sql =
                    "update thiet_bi set name = @name , state = @state " +
                    "where id = @id";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { name, state, id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void delete(int id)
        {
            try
            {
                String sql =
                    "delete from thiet_bi " +
                    "where id = @id";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
