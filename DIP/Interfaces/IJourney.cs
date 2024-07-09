namespace DIP.Interfaces;

public interface IJourney
{
    string Destination { get; set; }
    ITruckDriver Driver { get; set; }
    double HoursDriven { get; }
    bool IsCompleted { get; }
    void PerformedDrive(double hours);
    void CompleteJourney();
}