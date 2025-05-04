using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace web_qly_thuquan.Models
{
    public class LichSuVaoModel
    {
        private static LichSuVaoModel instance = null;
        private LichSuVaoModel() { }
        public static LichSuVaoModel getInstance()
        {
            if (instance == null) instance = new LichSuVaoModel();
            return instance;
        }
        public List<LichSuVao> getAll()
        {
            List<LichSuVao> ls = new List<LichSuVao>();
            try
            {
                string sql =
                    "select * " +
                    "from vao_tq " +
                    "order by time_in desc";
                DataTable dt = DataProvider.GetInstance().ExecuteQuery(sql);
                foreach (DataRow dr in dt.Rows)
                    ls.Add(new LichSuVao(dr));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ls;
        }
    }
}