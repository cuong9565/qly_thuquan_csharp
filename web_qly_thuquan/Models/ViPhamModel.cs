using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace web_qly_thuquan.Models
{
    public class ViPhamModel
    {
        private static ViPhamModel instance = null;
        private ViPhamModel() { }
        public static ViPhamModel getInstance()
        {
            if (instance == null) instance = new ViPhamModel();
            return instance;
        }
        public List<ViPham> getAll()
        {
            List<ViPham> ls = new List<ViPham>();
            try
            {
                string sql =
                    "select * " +
                    "from vi_pham " +
                    "order by id desc";
                DataTable dt = DataProvider.GetInstance().ExecuteQuery(sql);
                foreach (DataRow dr in dt.Rows)
                    ls.Add(new ViPham(dr));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ls;
        }
        public void checkViPham(string idTV)
        {
            try
            {
                string sql =
                    "select * " +
                    "from vi_pham " +
                    "where idTV = @idTV and state = 'Chưa xử lý'";
                DataTable dt = DataProvider.GetInstance().ExecuteQuery(sql, new object[] {idTV});
                if (dt.Rows.Count > 0)
                    throw new Exception("Thành viên đang bị xử lý vi phạm");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}