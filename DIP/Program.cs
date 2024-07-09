namespace DIP;

internal class Program
{
    private static void Main()
    {
        var driver = Factory.CreateDriver();
        driver.FirstName = "John";
        driver.LastName = "Doe";
        driver.EmailAddress = "johndoe@email.com";
        driver.PhoneNumber = "1234567890";

        var trip = Factory.CreateJourney();
        trip.Destination = "Paris";
        trip.Driver = driver;

        trip.PerformedDrive(3);
        trip.PerformedDrive(4);
        trip.CompleteJourney();

        Console.ReadLine();
    }
}