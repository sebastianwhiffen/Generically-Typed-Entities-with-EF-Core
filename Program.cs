using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<MyDB>().UseInMemoryDatabase("test").Options;

var context = new MyDB(options);

var repo = new GenericRepository<Client>(context);

repo.Add(new Client<SoleTrader>()
{
    Data = new()
    {
        FirstName = "Sole",
        LastName = "Trader",
        ABN = 123,
        TradingName = "Mr SoleTrader Business"
    }
});

repo.Add(new Client<Individual>()
{
    Data = new()
    {
        FirstName = "Indy",
        LastName = "Vidual",
    }
});

repo.Add(new Client<Company>()
{
    Data = new()
    {
        TradingName = "Company Incorporated",
        ABN = 321,
    }
});

context.SaveChanges();

//the all powerful querier
//the omnipotent grabber
//the safe and generic mega caller
//my baby.
repo.Get().OfType<Client>().ToList().ForEach(x => Console.WriteLine(x.GetDisplayName()));

//gets individuals from the DB
repo.Get().OfType<Client<Individual>>().ToList().ForEach(x => Console.WriteLine(x.GetDisplayName()));

//gets companies
repo.Get().OfType<Client<Company>>().ToList().ForEach(x => Console.WriteLine(x.GetDisplayName()));

//you get the idea
repo.Get().OfType<Client<SoleTrader>>().ToList().ForEach(x => Console.WriteLine(x.GetDisplayName()));


