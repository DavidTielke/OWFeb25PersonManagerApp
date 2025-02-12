using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollectionFactory().Create();

            collection.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();

            var provider = collection.BuildServiceProvider();

            var displayCommands = provider.GetRequiredService<IPersonDisplayCommands>();

            displayCommands.DisplayAllAdults();

            displayCommands.DisplayAllChildren();
        }
    }
}
