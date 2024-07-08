using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class FirstTeamModel : ISigningModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IPlayerRegister PlayerRegister { get; set; } = new FirstTeamRegister();
    }
}
