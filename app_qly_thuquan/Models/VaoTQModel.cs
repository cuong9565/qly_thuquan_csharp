using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qly_thuquan.Model;

namespace qly_thuquan.Models
{
    public class VaoTQModel
    {
        private static VaoTQModel instance = null;
        private VaoTQModel() { }
        public static VaoTQModel getInstance()
        {
            if (instance == null) instance = new VaoTQModel();
            return instance;
        }
        public void insert(string idTV, DateTime dt) {
            string sql =
                "insert into vao_tq(idTV, time_in) " +
                "values( @idTV , @time_in )";
            try
            {
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] {idTV, dt});
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
    }
}
