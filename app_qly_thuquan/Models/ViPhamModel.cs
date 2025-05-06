using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using qly_thuquan.Model;

namespace qly_thuquan.Models
{
    public class ViPhamModel
    {
        private static ViPhamModel instance = null;
        public static ViPhamModel getInstance()
        {
            if (instance == null) instance = new ViPhamModel();
            return instance;
        }
        public DataTable loadByIdTV(string idTV)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql =
                    "select vp.id as 'Mã số', vp.name as 'Tên vi phạm', vp.price as 'Mức phạt', vp.dateCreate as 'Thời gian vi phạm', vp.state as 'Trạng thái' " +
                    "from vi_pham vp " +
                    "where idTV = @idTV";
                dt = DataProvider.getInstance().ExecuteQuery(sql, new object[] {idTV});
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }
        public void checkViPham(string idTV)
        {
            try
            {
                string sql =
                    "select * " +
                    "from vi_pham " +
                    "where idTV = @idTV and state = 'Chưa xử lý'";
                DataTable dt = DataProvider.getInstance().ExecuteQuery(sql, new object[] { idTV });
                if (dt.Rows.Count > 0)
                    throw new Exception("Thành viên đang bị xử lý vi phạm!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void insert(string idTV, string name, double price)
        {
            try
            {
                string sql =
                    "insert into vi_pham(idTV, name, price) " +
                    "values( @idTV , @name , @price )";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] {idTV, name, price});
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void update(int id, string name, double price, string state)
        {
            try
            {
                string sql =
                    "update vi_pham " +
                    "set name = @name , price = @price , state = @state " +
                    "where id = @id";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { name, price, state, id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void delete(int id) {
            try
            {
                string sql =
                    "delete from vi_pham " +
                    "where id = @id";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void XuLy(int id, string state)
        {
            try
            {
                string sql =
                    "update vi_pham " +
                    "set state = @state " +
                    "where id = @id";
                DataProvider.getInstance().ExecuteNonQuery(sql, new object[] { state, id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // Thống kê
        public int NumVPDaXuLy()
        {
            try
            {
                string sql =
                    "select count(*) " +
                    "from vi_pham " +
                    "where state = 'Đã xử lý'";
                DataTable dt = DataProvider.getInstance().ExecuteQuery(sql);
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int NumVPChuaXuLy()
        {
            try
            {
                string sql =
                    "select count(*) " +
                    "from vi_pham " +
                    "where state = 'Chưa xử lý'";
                DataTable dt = DataProvider.getInstance().ExecuteQuery(sql);
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public double NumVPBoiThuong()
        {
            try
            {
                string sql =
                    "select sum(price) " +
                    "from vi_pham " +
                    "where state = 'Đã xử lý'";
                DataTable dt = DataProvider.getInstance().ExecuteQuery(sql);
                return Convert.ToDouble(dt.Rows[0][0]);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
