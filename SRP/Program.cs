using NOSRP;
using SRP;

class Program
{
    static void Main(string[] args)
    {
        StandardMessages.SayWelcome();

        var birthDate = new BirthDate();

        StandardMessages.AskForData("year");

        string? year = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(year))
        {
            Console.WriteLine("The year you inserted was empty!");
            Console.ReadLine();
            return;
        }

        if (!int.TryParse(year, out birthDate.Year))
        {
            Console.WriteLine("The year you inserted was not a number!");
            Console.ReadLine();
            return;
        }

        StandardMessages.AskForData("month");

        string? month = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(month))
        {
            Console.WriteLine("The month you inserted was empty!");
            Console.ReadLine();
            return;
        }

        if (!int.TryParse(month, out birthDate.Month))
        {
            Console.WriteLine("The month you inserted was not a number!");
            Console.ReadLine();
            return;
        }

        StandardMessages.AskForData("day");

        string? day = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(day))
        {
            Console.WriteLine("The day you inserted was empty!");
            Console.ReadLine();
            return;
        }

        if (!int.TryParse(day, out birthDate.Day))
        {
            Console.WriteLine("The day you inserted was not a number!");
            Console.ReadLine();
            return;
        }

        Console.WriteLine($"Your date of birth is {birthDate.Day}/{birthDate.Month}/{birthDate.Year}");

    }
}