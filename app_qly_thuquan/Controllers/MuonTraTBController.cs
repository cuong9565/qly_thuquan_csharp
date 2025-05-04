using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qly_thuquan.Models;

namespace qly_thuquan.Controllers
{
    internal class MuonTraTBController
    {
        private static MuonTraTBController instance = null;
        private MuonTraTBController() { }
        public static MuonTraTBController getInstance()
        {
            if (instance == null) instance = new MuonTraTBController();
            return instance;
        }
    }
}
