public class Client<T> : Client where T : IClient, new()
{
    public T Data { get; set; }

    public Client()
    {
        Data = Activator.CreateInstance<T>();
    }
    public override string GetDisplayName() => Data.GetDisplayName();
}

public abstract class Client
{
    public int ID { get; set; }
    public abstract string GetDisplayName();
};