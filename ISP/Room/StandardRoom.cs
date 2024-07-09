using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISP.Room.Interfaces;

namespace ISP.Room
{
    public class StandardRoom : IBookableRoom
    {
        public DateTime FreeDate { get; set; }
        public string Booker { get; set; }
        public int BookDurationDays { get; set; }
        public string RoomId { get; set; }
        public int RoomNumber { get; set; }
        public void CheckIn(int days, string booker)
        {
            Booker = booker;
            BookDurationDays = days;
            FreeDate = GetNextFreeDate();
        }

        public void CheckOut()
        {
            Booker = "";
            FreeDate = DateTime.Now;

        }

        public DateTime GetNextFreeDate()
        {
            return FreeDate.AddDays(BookDurationDays);
        }
    }
}
