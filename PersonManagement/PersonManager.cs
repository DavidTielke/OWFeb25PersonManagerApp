using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using DavidTielke.PersonManagerApp.Data.DataStoring;

namespace DavidTielke.PersonManagerApp.Logic.PersonManagement;

public class PersonManager
{
    private readonly PersonRepository _personRepository;

    public PersonManager()
    {
        _personRepository = new PersonRepository();
    }

    public IQueryable<Person> GetAllAdults()
    {
        var query = _personRepository
            .Query()
            .Where(p => p.Age >= 18);
        return query;
    }

    public Person Copy()
    {
        return default;
    }
    public IQueryable<Person> GetAllChildren()
    {
        var query = _personRepository
            .Query()
            .Where(p => p.Age < 18);
        return query;
    }
}