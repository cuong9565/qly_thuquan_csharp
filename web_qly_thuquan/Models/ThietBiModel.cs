using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_qly_thuquan.Models;

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
        public List<ThietBi> getAll()
        {
            List<ThietBi> ls = new List<ThietBi>();
            try
            {
                string sql =
                    "select *" +
                    "from thiet_bi";
                DataTable dt = DataProvider.GetInstance().ExecuteQuery(sql);
                foreach (DataRow dr in dt.Rows)
                    ls.Add(new ThietBi(dr));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ls;
        }
        public void updateState(string id, string state)
        {
            try
            {
                string sql =
                    "update thiet_bi " +
                    "set state = @state " +
                    "where id = @id";
                DataProvider.GetInstance().ExecuteNonQuery(sql, new object[] {state, id});
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
