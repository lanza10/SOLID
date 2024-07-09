using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOISP
{
    public interface IRoom
    {
        string RoomName { get; set; }
        DateTime FreeDate { get; set; }
        string Booker { get; set; }
        int BookDurationDays { get; set; }
        string RoomId { get; set; }
        int RoomNumber { get; set; }
        string RoomDescription { get; set; }
        void CheckIn(int days, string booker);
        void CheckOut();
        DateTime GetNextFreeDate();
    }
}
