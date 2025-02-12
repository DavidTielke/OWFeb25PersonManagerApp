using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using DavidTielke.PersonManagerApp.Data.FileStoring;

namespace DavidTielke.PersonManagerApp.Data.DataStoring;

public class PersonRepository : IPersonRepository
{
    private readonly IPersonParser _personParser;
    private readonly IFileReader _fileReader;

    public PersonRepository(IPersonParser personParser, IFileReader fileReader)
    {
        _personParser = personParser;
        _fileReader = fileReader;
    }

    public IQueryable<Person> Query()
    {
        var dataLines = _fileReader.ReadLines("data.csv");
        var persons = dataLines.Select(l => _personParser.Parse(l));
        return persons.AsQueryable();
    }
}