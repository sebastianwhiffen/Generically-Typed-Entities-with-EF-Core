using System.Reflection;
using Microsoft.EntityFrameworkCore;

public class MyDB : DbContext
{
    public MyDB(DbContextOptions options) : base(options){}

    public DbSet<Client> Clients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.MapClientTypes();
    }
}

public static class ModelBuilderHelper
{
    public static void MapClientTypes(this ModelBuilder modelBuilder)
    {
        var clientTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && typeof(IClient).IsAssignableFrom(t))
            .ToList();

        foreach (var clientType in clientTypes)
        {
            var genericClientType = typeof(Client<>).MakeGenericType(clientType);
            var entityTypeBuilder = modelBuilder.Entity(genericClientType);
            var dataProperty = genericClientType.GetProperty("Data");
            entityTypeBuilder.OwnsOne(dataProperty.PropertyType, dataProperty.Name);
        }
    }
}
