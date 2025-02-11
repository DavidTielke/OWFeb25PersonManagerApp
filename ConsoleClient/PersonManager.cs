namespace ConsoleClient;

class PersonManager
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
    public IQueryable<Person> GetAllChildren()
    {
        var query = _personRepository
            .Query()
            .Where(p => p.Age < 18);
        return query;
    }
}