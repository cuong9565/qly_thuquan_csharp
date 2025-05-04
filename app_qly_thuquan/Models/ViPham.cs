using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg.Sig;

namespace qly_thuquan.Models
{
    public class ViPham
    {
        private int id = 0;
        private string idTV = "";
        private string name = "";
        private double price = 0;
        private DateTime dateCreate = new DateTime();
        private string state = "";

        public ViPham() { }
        public ViPham(int id, string idTV, string name, double price, DateTime dateCreate, string state)
        {
            this.id = id;
            this.idTV = idTV;
            this.name = name;
            this.price = price;
            this.dateCreate = dateCreate;
            this.state = state;
        }
        public ViPham(DataRow dr)
        {
            id = (int)dr["id"];
            idTV = (string)dr["idTV"];
            name = (string)dr["name"];
            price = (double)dr["price"];
            dateCreate = (DateTime)dr["dateCreate"];
            state = (string)dr["state"];
        }
        public int getId() { return id; }
        public string getIdTV() { return idTV; } 
        public string getName() { return name; }
        public DateTime getDateCreate() { return dateCreate; }
        public double getPrice() { return price; }
        public string getState() { return state; }
        public void setId(int id) { this.id = id;}
        public void setIdTV(string idTV) { this.idTV = idTV; }
        public void setName(string name) { this.name = name;}
        public void setDateCreate(DateTime dateTime) { this.dateCreate = dateTime;}
        public void setState(string state) { this.state = state;}

    }
}
