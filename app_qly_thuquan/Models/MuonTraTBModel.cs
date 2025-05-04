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

    }
}
