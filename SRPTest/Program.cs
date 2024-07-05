﻿using NOSRP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");

        var birthDate = new BirthDate();

        Console.WriteLine("Insert the year you were born:");
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

        Console.WriteLine("Insert the month you were born:");

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

        Console.WriteLine("Insert the day you were born:");

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