using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IBookable
    {
        DateTime FreeDate { get; set; }
        string Booker { get; set; }
        int BookDurationDays { get; set; }
        void CheckIn(int days, string booker);
        void CheckOut();
        DateTime GetNextFreeDate();
    }
}
