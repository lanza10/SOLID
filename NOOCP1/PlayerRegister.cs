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
                ShirtName = $"{person.FirstName[..1]}.{person.LastName}",
                Value = new Random().Next(1,3)
            };
            switch (person.TypeOfPlayer)
            {
                case PlayerType.Standard:
                    break;
                case PlayerType.FirstTeam:
                    player.IsFistTeamPlayer = true;
                    player.Value = new Random().Next(10, 32);
                    break;
                case PlayerType.Crack:
                    player.IsFistTeamPlayer = true;
                    player.isCrack = true;
                    player.ShirtName = person.LastName;
                    player.Value = new Random().Next(50, 200);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return player;
        }
    }
}
