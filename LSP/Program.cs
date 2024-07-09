namespace LSP
{
    public class Program
    {
        private static void Main()
        {
            var crack = new Crack
            {
                FirstName = "Manu",
                LastName = "Hernando"
            };

            crack.CalculateValue(7);

            //var player = new Player
            var player = new Player
            {
                FirstName = "Juan",
                LastName = "Gutiérrez"
            };

            player.AssignReferencePlayer(crack);
            player.CalculateValue(4);

            Console.WriteLine($"{player.FirstName}'s value is {player.Value}M");

            Console.ReadLine();
        }
    }
   
}

