namespace ConsoleClient;

class FileReader
{
    public IEnumerable<string> ReadLines(string path)
    {
        return File.ReadAllLines(path);
    }
}