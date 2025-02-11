namespace ConsoleClient;

class PersonRepository
{
    private readonly PersonParser _personParser;
    private readonly FileReader _fileReader;

    public PersonRepository()
    {
        _personParser = new PersonParser();
        _fileReader = new FileReader();
    }

    public IQueryable<Person> Query()
    {
        var dataLines = _fileReader.ReadLines("data.csv");
        var persons = dataLines.Select(l => _personParser.Parse(l));
        return persons.AsQueryable();
    }
}