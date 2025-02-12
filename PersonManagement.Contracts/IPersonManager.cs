using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Logic.PersonManagement;

public interface IPersonManager
{
    IQueryable<Person> GetAllAdults();
    IQueryable<Person> GetAllChildren();
}