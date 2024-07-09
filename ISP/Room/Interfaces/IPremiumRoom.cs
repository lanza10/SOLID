using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Room.Interfaces
{
    public interface IPremiumRoom : IRoom
    {
        string RoomName { get; set; }
        string RoomDescription { get; set; }
    }
}
