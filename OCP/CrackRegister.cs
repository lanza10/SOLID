using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class CrackRegister : IPlayerRegister
    {
        public PlayerModel Register(ISigningModel person)
        {
            var player = new PlayerModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                ShirtName = person.LastName,
                Value = new Random().Next(1, 27),
                IsFistTeamPlayer = true,
                IsCrack = true
                
            };
            return player;
        }
    }
}
