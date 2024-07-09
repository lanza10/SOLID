using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISP.Room.Interfaces;

namespace ISP.Suite
{
    public interface ISuite : IPremiumRoom
    {
        List<string> ExtraServices { get; set; }

        int ExtraPrice { get; set; }
    }
}
