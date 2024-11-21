public class SoleTrader : IClient, ICompany, IIndividual
{
    public int ABN { get; set; } = 000000;
    public string TradingName { get; set; } = "unknown";
    public string FirstName { get; set; } = "unknown";
    public string LastName { get; set; } = "unknown";
    public string GetDisplayName() => FirstName + " " + LastName + " From " + TradingName + " " + ABN;
}
