using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using qly_thuquan.Model;

namespace qly_thuquan.Models
{
    public class VaoTQ
    {
        int id = 0;
        ThanhVien tv = new ThanhVien();
        DateTime time_in = new DateTime();

        public VaoTQ() { }
        public VaoTQ(int id, ThanhVien tv, DateTime time_in)
        {
            this.id = id;
            this.tv = tv;
            this.time_in = time_in;
        }

        public int getId() { return id; }
        public ThanhVien getTv() { return tv; }
        public DateTime getTimeIn() { return time_in; }

        public void setId(int id) { this.id = id; }
        public void setTv(ThanhVien tv) { this.tv = tv; }
        public void setTime_in(DateTime time_in) {  this.time_in = time_in;}
    }
}
