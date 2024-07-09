using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Luxury
{
    public interface IBookableLuxury : ILuxury, IBookable
    {
    }
}
