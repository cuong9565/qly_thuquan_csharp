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
        public string Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }

        public ThietBi() { }

        public ThietBi(string id, string name, string state)
        {
            Id = id;
            Name = name;
            State = state;
        }

        public ThietBi(DataRow row)
        {
            Id = (string)row["id"];
            Name = (string)row["name"];
            State = (string)row["state"];
        }
    }
}
