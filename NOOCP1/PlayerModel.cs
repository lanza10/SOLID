using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOOCP
{
    public class PlayerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ShirtName { get; set; }
        public int Value { get; set; }
        public bool IsFistTeamPlayer { get; set; } = false;
        public bool isCrack { get; set; } = false;
    }
}
