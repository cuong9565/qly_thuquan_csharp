using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qly_thuquan.Controller;
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
                VaoTQModel.getInstance().insert(idTV, dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
