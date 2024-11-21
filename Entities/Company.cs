public class Company : IClient, ICompany
{
    public int ABN { get; set; } = 000000;
    public string TradingName { get; set; } = "unknown";
    public string GetDisplayName() => TradingName + " " + ABN;
}
