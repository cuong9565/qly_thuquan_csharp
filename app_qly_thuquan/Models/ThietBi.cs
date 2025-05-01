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
        private int id;
        private string name;
        private string state;
        public ThietBi() { }
        public ThietBi(int id, string name, string state)
        {
            this.id = id;
            this.name = name;
            this.state = state;
        }
        public ThietBi(DataRow row)
        {
            id = (int)row["id"];
            name = (string)row["name"];
            state = (string)row["state"];
        }
        public int getId() { return id; }
        public string getName() { return name; }
        public string getState() { return state; }
        public void setId(int id) { this.id = id;}
        public void setName(string name) { this.name = name;}
        public void setState(string state) { this.state = state;}
    }
}
