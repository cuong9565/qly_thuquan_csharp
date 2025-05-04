using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qly_thuquan.Model;

namespace qly_thuquan.Models
{
    public class MuonTraTB
    {
        private int id;
        private ThanhVien tv;
        private ThietBi tb;
        private DateTime timeBook;
        private DateTime timeBorrow;
        private DateTime timeReturn;
        private string state;

        public MuonTraTB() { }
        public MuonTraTB(int id, ThanhVien tv, ThietBi tb, DateTime timeBook, DateTime timeBorrow, DateTime timeReturn, string state)
        {
            this.id = id;
            this.tv = tv;
            this.tb = tb;
            this.timeBook = timeBook;
            this.timeBorrow = timeBorrow;
            this.timeReturn = timeReturn;
            this.state = state;
        }
        public int getId() { return id; }
        public ThanhVien getTv() { return tv; }
        public ThietBi getTb() { return tb; }
        public DateTime getTimeBook() { return timeBook; }
        public DateTime getTimeBorrow() { return timeBorrow; }
        public DateTime getTimeReturn() { return timeReturn; } 
        public string getState() { return state; }
        public void setId(int id) { this.id = id; }
        public void setTv(ThanhVien tv ) { this.tv = tv; }
        public void setTb(ThietBi tb) { this.tb = tb; }
        public void setTimeBook(DateTime timeBook) { this.timeBook = timeBook; }
        public void setTimeBorrow(DateTime timeBorrow) { this.timeBorrow = timeBorrow; }
        public void setTimeReturn(DateTime timeReturn) { this.timeReturn = timeReturn; }
        public void setState(string state) { this.state = state; }
    }
}
