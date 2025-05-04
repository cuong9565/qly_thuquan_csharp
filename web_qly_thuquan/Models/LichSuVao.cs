using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace web_qly_thuquan.Models
{
    public class LichSuVao
    {
        public int Id { get; set; }
        public string IdTV { get; set; }
        public DateTime TimeIn { get; set; }
        public string FomartTimeIn { get; set; }

        public LichSuVao() { }
        public LichSuVao(int id, string idTV, DateTime timeIn, string fomartTimeIn)
        {
            Id = id;
            IdTV = idTV;
            TimeIn = timeIn;
            FomartTimeIn = fomartTimeIn;
        }
        public LichSuVao(DataRow dr)
        {
            Id = (int)dr["id"];
            IdTV = (string)dr["idTV"];
            TimeIn = (DateTime)dr["time_in"];
            FomartTimeIn = TimeIn.ToString("dd/MM/yyyy - hh:mm:ss - tt");
        }
    }
}