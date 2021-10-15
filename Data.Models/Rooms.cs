using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Data.Models
{
    public class Rooms
    {
        public int Id { get; set; }
        public int? RtCode { get; set; }
        public bool? Status { get; set; }
        public RoomTypes RoomTypes { get; set; }
    }
}
