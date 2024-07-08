namespace OCP;

public interface ISigningModel
{
    string FirstName { get; set; }
    string LastName { get; set; }
    IPlayerRegister PlayerRegister { get; set; }
}