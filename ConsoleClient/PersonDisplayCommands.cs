using DavidTielke.PersonManagerApp.Logic.PersonManagement;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

class PersonDisplayCommands
{
    private readonly PersonManager _personManager;

    public PersonDisplayCommands()
    {
        _personManager = new PersonManager();
    }

    public void DisplayAllAdults()
    {
        var adults = _personManager.GetAllAdults().ToList();
        Console.WriteLine($"## ERWACHSENE ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));
    }

    public void DisplayAllChildren()
    {
        var children = _personManager.GetAllChildren().ToList();
        Console.WriteLine($"## Kinder ({children.Count}) ###");
        children.ForEach(a => Console.WriteLine(a.Name));
    }
}