using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable LoadDataTable()
        {
            try
            {
                return MuonTraTBModel.getInstance().LoadDataTable();
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
                MuonTraTBModel.getInstance().Muon(idTV, idTB);
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
                MuonTraTBModel.getInstance().Tra(idTB);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int NumDat(DateTime dtFrom, DateTime dtTo)
        {
            try
            {
                return MuonTraTBModel.getInstance().NumDat(dtFrom, dtTo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int NumMuon(DateTime dtFrom, DateTime dtTo)
        {
            try
            {
                return MuonTraTBModel.getInstance().NumMuon(dtFrom, dtTo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
