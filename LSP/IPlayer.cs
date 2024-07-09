namespace LSP;

public interface IPlayer
{
    string FirstName { get; set; }
    string LastName { get; set; }
    decimal Value { get; set; }
    void CalculateValue(int lastPerformance);
}