namespace DavidTielke.PersonManagerApp.Data.FileStoring;

public interface IFileReader
{
    IEnumerable<string> ReadLines(string path);
}