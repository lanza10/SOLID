using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOOCP
{
    public class PlayerRegister
    {
        public PlayerModel Register(PersonModel person)
        {
            var player = new PlayerModel
            {
                FirstName = person.FirstName,           
                LastName = person.LastName,
                ShirtName = $"{person.FirstName.Substring(0, 1)}.{person.LastName}",
                ShirtNumber = new Random().Next(1,999)
            };

            return player;
        }
    }
}
