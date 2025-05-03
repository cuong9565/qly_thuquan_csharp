using System;
using System.Data;

namespace web_qly_thuquan.Models
{
    public class ThanhVien
    {
        // Thuộc tính
        public string Id { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public DateTime DateCreate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string FomartedDateCreate {  get; set; }

        public ThanhVien() { }

        public ThanhVien(string id, string lName, string fName, DateTime dateCreate, string email, string phone, string password)
        {
            Id = id;
            LName = lName;
            FName = fName;
            DateCreate = dateCreate.Date;
            FomartedDateCreate = DateCreate.ToString("dd/MM/yyyy");
            Email = email;
            Phone = phone;
            Password = password;
        }

        public ThanhVien(DataRow row)
        {
            Id = row["id"] as string ?? "";
            LName = row["lName"] as string ?? "";
            FName = row["fName"] as string ?? "";
            DateCreate = row["dateCreate"] is DBNull ? DateTime.MinValue : (DateTime)row["dateCreate"];
            FomartedDateCreate = DateCreate.ToString("dd/MM/yyyy");
            Email = row["email"] as string ?? "";
            Phone = row["phone"] as string ?? "";
            Password = row["password"] as string ?? "";
        }
    }
}
