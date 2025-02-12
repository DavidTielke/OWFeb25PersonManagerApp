using DavidTielke.PersonManagerApp.Data.DataStoring;
using DavidTielke.PersonManagerApp.Data.FileStoring;
using DavidTielke.PersonManagerApp.Logic.PersonManagement;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

public class ServiceCollectionFactory
{
    public IServiceCollection Create()
    {
        var collection = new ServiceCollection();
        collection.AddTransient<IPersonManager, PersonManager>();
        collection.AddTransient<IPersonRepository, PersonRepository>();
        collection.AddTransient<IPersonParser, PersonParser>();
        collection.AddTransient<IFileReader, FileReader>();
        return collection;
    }
}