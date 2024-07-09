namespace DIP.Interfaces;

public interface IMessageSender
{
    void SendMessage(ITruckDriver truckDriver, string message);
}