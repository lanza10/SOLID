using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISP.Room.Interfaces;

namespace ISP.Luxury
{
    public interface ILuxury : IPremiumRoom
    {
        int ExtraPrice { get; set; }
    }
}
