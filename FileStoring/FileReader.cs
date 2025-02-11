namespace DavidTielke.PersonManagerApp.Data.FileStoring;

public class FileReader
{
    public IEnumerable<string> ReadLines(string path)
    {
        return File.ReadAllLines(path);
    }
}