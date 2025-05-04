using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace web_qly_thuquan.Models
{
    public class ViPham
    {
        public int Id { get; set; }
        public string IdTV { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string FormattedPrice {  get; set; }
        public DateTime DateCreate { get; set; }
        public string FormattedDateCreate { get; set; }
        public string State { get; set; }

        public ViPham() { }

        public ViPham(int id, string idTV, string name, double price, DateTime dateCreate, string state)
        {
            Id = id;
            IdTV = idTV;
            Name = name;
            Price = price;
            FormattedPrice = Price.ToString() + "đ";
            DateCreate = dateCreate;
            FormattedDateCreate = DateCreate.ToString("dd/MM/yyyy");
            State = state;
        }

        public ViPham(DataRow row)
        {
            Id = (int)row["id"];
            IdTV = (string)row["idTV"];
            Name = (string)row["name"];
            Price = Convert.ToDouble(row["price"]);
            FormattedPrice = Price.ToString() + "đ";
            DateCreate = (DateTime)row["dateCreate"];
            FormattedDateCreate = DateCreate.ToString("dd/MM/yyyy");
            State = (string)row["state"];
        }
    }

}