using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using DavidTielke.PersonManagerApp.Data.DataStoring;

namespace DavidTielke.PersonManagerApp.Logic.PersonManagement;

public class PersonManager : IPersonManager
{
    private readonly IPersonRepository _personRepository;

    public PersonManager(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public IQueryable<Person> GetAllAdults()
    {
        var query = _personRepository
            .Query()
            .Where(p => p.Age >= 18);
        return query;
    }

    public IQueryable<Person> GetAllChildren()
    {
        var query = _personRepository
            .Query()
            .Where(p => p.Age < 18);
        return query;
    }
}