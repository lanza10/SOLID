using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOISP
{
    public class EmployeesRoom : IRoom
    {
        public string RoomName { get; set; }
        public DateTime FreeDate { get; set; } 
        public string Booker { get; set; } = "";
        public int BookDurationDays { get; set; } = -1;
        public string RoomId { get; set; }
        public int RoomNumber { get; set; }
        public string RoomDescription { get; set; } = "";
        public void CheckIn(int days, string booker)
        {
            throw new NotImplementedException();
        }

        public void CheckOut()
        {
            throw new NotImplementedException();
        }

        public DateTime GetNextFreeDate()
        {
            throw new NotImplementedException();
        }
    }
}
