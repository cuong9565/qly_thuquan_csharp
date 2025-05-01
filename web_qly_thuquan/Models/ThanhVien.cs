using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace web_qly_thuquan.Models
{
    public class ThanhVien
    {
        private int id;
        private string fName;
        private string lName;
        private DateTime dateCreate;
        private string email;
        private string phone;
        private string password;
        public ThanhVien() { }
        public ThanhVien(int id, string fName, string lName, DateTime dateCreate, string email, string phone, string password)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.dateCreate = dateCreate.Date;
            this.email = email;
            this.phone = phone;
            this.password = password;
        }
        public ThanhVien(DataRow row)
        {
            id = (int)row["id"];
            fName = (string)row["fName"];
            lName = (string)row["lName"];
            dateCreate = (DateTime)row["dateCreate"];
            email = (string)row["email"];
            phone = (string)row["phone"];
            password = (string)row["password"];
        }

        public int GetId() { return id; }
        public void SetId(int value) { id = value; }

        public string GetfName() { return fName; }
        public void SetfName(string value) { fName = value; }

        public string GetlName() { return lName; }
        public void SetlName(string value) { lName = value; }

        public DateTime GetDateCreate() { return dateCreate.Date; }
        public void SetDateCreate(DateTime value) { dateCreate = value.Date; }

        public string GetEmail() { return email; }
        public void SetEmail(string value) { email = value; }

        public string GetPhone() { return phone; }
        public void SetPhone(string value) { phone = value; }

        public string GetPassword() { return password; }
        public void SetPassword(string value) { password = value; }
    }
}