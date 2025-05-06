using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qly_thuquan.Model;

namespace qly_thuquan.Models
{
    public class MuonTraTBModel
    {
        private static MuonTraTBModel instance = null;
        private MuonTraTBModel() { }
        public static MuonTraTBModel getInstance()
        {
            if (instance == null) instance = new MuonTraTBModel();
            return instance;
        }
        public DataTable LoadDataTable()
        {
            try
            {
                string sql =
                    "select tb.id as 'Mã thiết bị', tv.id 'Mã thành viên', mt.time_book as 'Thời gian đặt', mt.time_borrow  as 'Thời gian mượn', mt.time_return as 'Thời gian trả', mt.state as 'Trạng thái' " +
                    "from muon_tra_tb mt " +
                    "join thanh_vien tv on mt.idTV = tv.id " +
                    "join thiet_bi tb on mt.idTB = tb.id " +
                    "order by mt.id desc";
                return DataProvider.getInstance().ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Muon(string idTV, string idTB)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                string sql =
                    "update muon_tra_tb " +
                    "set time_borrow = @time_borrow , state = 'Đang mượn' " +
                    "where idTV = @idTV and idTB = @idTB and state = 'Đang đặt chỗ'";
                int res = DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { dateTime, idTV, idTB });
                if (res == 0) throw new Exception("Thông tin không hợp lệ!");

                sql =
                "update thiet_bi " +
                "set state = 'Đang mượn' " +
                "where id = @idTB";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { idTB });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Tra(string idTB)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                string sql =
                    "update muon_tra_tb " +
                    "set time_return = @time_return , state = 'Đã trả' " +
                    "where idTB = @idTB and state = 'Đang mượn'";
                int res = DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { dateTime, idTB });
                if (res == 0) throw new Exception("Thông tin không hợp lệ!");

                sql =
                "update thiet_bi " +
                "set state = 'Sẵn sàng' " +
                "where id = @idTB";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { idTB });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Thong ke
        public int NumDat(DateTime dtFrom, DateTime dtTo)
        {
            try
            {
                string sql =
                    "select count(*) " +
                    "from muon_tra_tb " +
                    "where date(time_book) between @dtFrom and @dtTo";
                DataTable dt = DataProvider.getInstance().ExecuteQuery(sql, new object[] { dtFrom, dtTo });
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int NumMuon(DateTime dtFrom, DateTime dtTo)
        {
            try
            {
                string sql =
                    "select count(*) " +
                    "from muon_tra_tb " +
                    "where time_borrow is not null and date(time_borrow) between @dtFrom and @dtTo";
                DataTable dt = DataProvider.getInstance().ExecuteQuery(sql, new object[] { dtFrom, dtTo });
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
