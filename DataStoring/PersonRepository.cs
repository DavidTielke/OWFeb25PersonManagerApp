using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using DavidTielke.PersonManagerApp.Data.FileStoring;

namespace DavidTielke.PersonManagerApp.Data.DataStoring;

public class PersonRepository
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