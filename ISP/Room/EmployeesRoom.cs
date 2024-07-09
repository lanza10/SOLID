using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISP.Room.Interfaces;

namespace ISP.Room
{
    public class EmployeesRoom : IRoom
    {
        public string RoomId { get; set; }
        public int RoomNumber { get; set; }
    }
}
