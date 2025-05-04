using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qly_thuquan.Model
{
    public class ThietBi
    {
        private string id = "";
        private string name = "";
        private string state = "";
        public ThietBi() { }
        public ThietBi(string id, string name, string state)
        {
            this.id = id;
            this.name = name;
            this.state = state;
        }
        public ThietBi(DataRow row)
        {
            id = (string)row["thiet_bi.id"];
            name = (string)row["thiet_bi.name"];
            state = (string)row["thiet_bi.state"];
        }
        public string getId() { return id; }
        public string getName() { return name; }
        public string getState() { return state; }
        public void setId(string id) { this.id = id;}
        public void setName(string name) { this.name = name;}
        public void setState(string state) { this.state = state;}
    }
}
