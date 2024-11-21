public class Individual : IClient, IIndividual
{
    public string FirstName { get; set; } = "unknown";
    public string LastName { get; set; } = "unknown";
    public string GetDisplayName() => FirstName + " " + LastName;
}
