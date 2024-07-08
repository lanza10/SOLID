using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class CrackModel : ISigningModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IPlayerRegister PlayerRegister { get; set; } = new CrackRegister();
    }
}
