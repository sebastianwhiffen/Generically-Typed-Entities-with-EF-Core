public interface IClient
{
    public string GetDisplayName();
};

public interface IIndividual
{
    string FirstName {get; set;}
    public string LastName { get; set; }
};

public interface ICompany
{
    int ABN {get; set;}
    string TradingName {get; set;}
};