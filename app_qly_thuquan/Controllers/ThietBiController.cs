using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qly_thuquan.Model;

namespace qly_thuquan.Controller
{
    internal class ThietBiController
    {
        private static ThietBiController instance = null;
        private ThietBiController() { }
        public static ThietBiController getInstance()
        {
            if (instance == null) instance = new ThietBiController();
            return instance;
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = ThietBiModel.getInstance().getAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public ThietBi getById(string id)
        {
            ThietBi tv = new ThietBi();
            try
            {
                tv = ThietBiModel.getInstance().getById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tv;
        }
        public void insert(string id, string name)
        {
            try
            {
                if (id=="") throw new Exception("Mã không được để trống!");
                if (name == "") throw new Exception("Tên không được để trống!");
                if (ThietBiModel.getInstance().checkSame(id)) throw new Exception($"Mã thiết bị '{id}' đã tồn tại!");
                ThietBiModel.getInstance().insert(id, name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void update(string id, string name, string state)
        {
            try
            {
                if (name == "") throw new Exception("Tên không được để trống!");
                if (state == "") throw new Exception("Trạng thái không được để trống!");
                ThietBiModel.getInstance().update(id, name, state);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void delete(string id)
        {
            try
            {
                ThietBiModel.getInstance().delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int deleteByTopId(string top)
        {
            try
            {
                if (top.Length != 2) throw new Exception("Chuỗi nhập vào phải là 2 kí tự");
                return ThietBiModel.getInstance().deleteByTopId(top);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int NumTB()
        {
            try
            {
                return ThietBiModel.getInstance().NumTB();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
