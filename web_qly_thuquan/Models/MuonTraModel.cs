using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using qly_thuquan.Model;

namespace web_qly_thuquan.Models
{
    public class MuonTraModel
    {
        private static MuonTraModel instance = null;
        private MuonTraModel() { }
        public static MuonTraModel getInstance()
        {
            if (instance == null) instance = new MuonTraModel();
            return instance;
        }
        public List<MuonTra> getAll()
        {
            List<MuonTra> ls = new List<MuonTra>();
            try
            {
                string sql =
                    "select muon_tra_tb.*, tb.name " +
                    "from muon_tra_tb " +
                    "join thiet_bi tb on idTB = tb.id " +
                    "order by muon_tra_tb.id desc";
                DataTable dt = DataProvider.GetInstance().ExecuteQuery(sql);
                foreach (DataRow dr in dt.Rows)
                    ls.Add(new MuonTra(dr));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ls;
        }

        public void DatCho(string idTV, string idTB)
        {
            try
            {
                string sql =
                    "insert into muon_tra_tb(idTV, idTB) " +
                    "values( @idTV , @idTB )";
                DataProvider.GetInstance().ExecuteNonQuery(sql, new object[] { idTV, idTB });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void HuyDatCho(string idTV, string idTB)
        {
            try
            {
                string sql =
                    "update muon_tra_tb " +
                    "set state = 'Đã hủy' " +
                    "where idTV = @idTV and idTB = @idTB";
                DataProvider.GetInstance().ExecuteNonQuery(sql, new object[] { idTV, idTB });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}