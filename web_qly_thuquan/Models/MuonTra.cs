using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace web_qly_thuquan.Models
{
    public class MuonTra
    {
        public int Id { get; set; }
        public string IdTV { get; set; }
        public string IdTB { get; set; }
        public string NameTB { get; set; }
        public DateTime TimeBook { get; set; }
        public DateTime TimeBorrow { get; set; }
        public DateTime TimeReturn { get; set; }
        public string FomartedTimeBook { get; set; } = "";
        public string FomartedTimeBorrow { get; set; } = "";
        public string FomartedTimeReturn { get; set; } = "";
        public string State { get; set; }

        public MuonTra() { }

        public MuonTra(int id, string idTV, string idTB, string nameTB, DateTime timeBook, DateTime timeBorrow, DateTime timeReturn, string state)
        {
            Id = id;
            IdTV = idTV;
            IdTB = idTB;
            NameTB = nameTB;
            TimeBook = timeBook;
            TimeBorrow = timeBorrow;
            TimeReturn = timeReturn;
            State = state;
        }

        public MuonTra(DataRow row)
        {
            Id = (int)row["id"];
            IdTV = (string)row["idTV"];
            IdTB = (string)row["idTB"];
            NameTB = (string)row["name"];
            TimeBook = (DateTime)row["time_book"];
            FomartedTimeBook = TimeBook.ToString("dd/MM/yyyy - hh:mm:ss - tt");
            if (row["time_borrow"] != DBNull.Value)
            {
                TimeBorrow = (DateTime) row["time_borrow"];
                FomartedTimeBorrow = TimeBorrow.ToString("dd/MM/yyyy - hh:mm:ss - tt");
            }
            if (row["time_return"] != DBNull.Value)
            {

                TimeReturn = (DateTime)row["time_return"];
                FomartedTimeReturn = TimeReturn.ToString("dd/MM/yyyy - hh:mm:ss - tt");
            }
            State = (string)row["state"];
        }
    }
}