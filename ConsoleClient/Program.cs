namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var displayCommands = new PersonDisplayCommands();

            displayCommands.DisplayAllAdults();

            displayCommands.DisplayAllChildren();
        }
    }
}
