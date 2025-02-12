using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.DataStoring;

public interface IPersonParser
{
    Person Parse(string dataLine);
}