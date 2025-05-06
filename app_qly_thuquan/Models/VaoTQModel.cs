using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable getAll()
        {
            try
            {
                string sql =
                    "select tv.id as 'MSSV', tv.lName as 'Họ', tv.fName as 'Tên', tv.dateCreate as 'Ngày đăng ký', tv.email as 'Email', tv.phone as 'Số điện thoại', tq.time_in as 'Thời gian vào' " +
                    "from vao_tq tq " +
                    "join thanh_vien tv on tq.idTV = tv.id " +
                    "order by tq.id desc";
                return DataProvider.getInstance().ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
