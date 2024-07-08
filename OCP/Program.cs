

namespace OCP
{
    

    class Program{
        static void Main()
        {
            List<ISigningModel> signings =
            [
                new PersonModel{ FirstName = "John", LastName = "Doe"},
                new FirstTeamModel{ FirstName = "Alex", LastName = "Doe" },
                new CrackModel{ FirstName = "Mark", LastName = "Test"},
            ];


            var players = signings.Select(person => person.PlayerRegister.Register(person)).ToList();

            foreach (var player in players )
            {
                Console.WriteLine($"\t{player.FirstName}\t{player.LastName}\t{player.ShirtName}\t{player.Value}M\tIsFirstTeamPlayer = {player.IsFistTeamPlayer}\tIsCrack = {player.IsCrack}");
            }

            Console.ReadLine();
        }
    }
}
