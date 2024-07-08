using NOSRP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");

        var birthDate = new BirthDate();

        Console.WriteLine("Insert the year you were born:");
        var year = Console.ReadLine();
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

        if (birthDate.Year is < 0 or > 2024)
        {
            Console.WriteLine("The year you inserted is out of range");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("Insert the month you were born:");

        var month = Console.ReadLine();
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

        if (birthDate.Month is < 0 or > 12)
        {
            Console.WriteLine("The month you inserted is out of range");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("Insert the day you were born:");

        var day = Console.ReadLine();
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
        if (birthDate.Day is < 0 or > 31)
        {
            Console.WriteLine("The day you inserted is out of range");
            Console.ReadLine();
            return;
        }

        Console.WriteLine($"Your date of birth is {birthDate.Day}/{birthDate.Month}/{birthDate.Year}");

    }
}