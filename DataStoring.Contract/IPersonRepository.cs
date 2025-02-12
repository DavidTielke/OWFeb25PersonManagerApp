using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.DataStoring;

public interface IPersonRepository
{
    IQueryable<Person> Query();
}