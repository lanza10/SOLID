using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOOCP
{
    public class PersonModel()
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerType TypeOfPlayer { get; set; } = PlayerType.Standard;
    }
}
