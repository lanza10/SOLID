

using NOOCP;

namespace NOOCP
{
    

    class Program{
        static void Main()
        {
            List<PersonModel> signings =
            [
                new PersonModel{ FirstName = "John", LastName = "Doe"},
                new PersonModel{ FirstName = "Alex", LastName = "Doe" , TypeOfPlayer = PlayerType.FirstTeam},
                new PersonModel{ FirstName = "Mark", LastName = "Test", TypeOfPlayer = PlayerType.Crack},
            ];

            var register = new PlayerRegister();

            var players = signings.Select(person => register.Register(person)).ToList();

            foreach (var player in players )
            {
                Console.WriteLine($"\t{player.FirstName}\t{player.LastName}\t{player.ShirtName}\t{player.Value}M\tIsFirstTeamPlayer = {player.IsFistTeamPlayer}\tIsCrack = {player.isCrack}");
            }

            Console.ReadLine();
        }
    }
}
