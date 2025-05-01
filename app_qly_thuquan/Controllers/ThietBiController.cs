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
        public ThietBi getById(int id)
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
        public void insert(string name)
        {
            try
            {
                if (name == "") throw new Exception("Tên không được để trống!");
                if (ThietBiModel.getInstance().checkSame(name)) throw new Exception($"Tên thiết bị '{name}' đã tồn tại!");
                ThietBiModel.getInstance().insert(name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void update(int id, string name, string state)
        {
            try
            {
                if (name == "") throw new Exception("Tên không được để trống!");
                if (state == "") throw new Exception("Trạng thái không được để trống!");
                    
                ThietBi tb = ThietBiModel.getInstance().getById(id);
                if (ThietBiModel.getInstance().checkSame(name) && tb.getName()!=name) 
                    throw new Exception($"Tên thiết bị '{name}' đã tồn tại!");
                ThietBiModel.getInstance().update(id, name, state);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void delete(int id)
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
    }
}
