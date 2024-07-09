using NODIP;

class Program
{
    static void Main()
    {
        var driver = new TruckDriver
        {
            FirstName = "John",
            LastName = "Doe",
            EmailAddress = "johndoe@email.com",
            PhoneNumber = "1234567890"
        };

        var trip = new Journey
        {
            Destination = "Paris",
            Driver = driver
        };

        trip.PerformedDrive(3);
        trip.PerformedDrive(4);
        trip.CompleteJourney();

        Console.ReadLine();
    }
}