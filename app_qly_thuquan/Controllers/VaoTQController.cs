using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qly_thuquan.Controller;
using qly_thuquan.Model;
using qly_thuquan.Models;

namespace qly_thuquan.Controllers
{
    public class VaoTQController
    {
        private static VaoTQController instance = null;
        private VaoTQController() { }
        public static VaoTQController getInstance()
        {
            if (instance == null) instance = new VaoTQController();
            return instance;
        }
        public void insert(string idTV, DateTime dt)
        {
            try
            {
                ViPhamModel.getInstance().checkViPham(idTV);
                VaoTQModel.getInstance().insert(idTV, dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public DataTable getAll()
        {
            try
            {
                return VaoTQModel.getInstance().getAll();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int NumVao(DateTime dtFrom, DateTime dtTo)
        {
            try
            {
                return VaoTQModel.getInstance().NumVao(dtFrom, dtTo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
