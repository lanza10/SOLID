using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class PlayerRegister : IPlayerRegister
    {
        public PlayerModel Register(ISigningModel person)
        {
            var player = new PlayerModel
            {
                FirstName = person.FirstName,           
                LastName = person.LastName,
                ShirtName = $"{person.FirstName[..1]}.{person.LastName}",
                Value = new Random().Next(1,3)
            };
            return player;
        }
    }
}
