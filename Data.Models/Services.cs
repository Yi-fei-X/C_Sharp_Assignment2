using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Data.Models
{
    public class Services
    {
        public int Id { get; set; }
        public int? RoomNo { get; set; }
        public string SDesc { get; set; }
        public decimal? Amount { get; set; }
        public DateTime ServiceDate { get; set; }
        public Rooms Rooms { get; set; }
    }
}
