namespace MatchingFileFinder;

public interface IFileSearcher
{
    string[] SearchFiles(string directoryPath, string searchPattern);
}


public class FileSearcherStub : IFileSearcher
{
    public string[] SearchFiles(string directoryPath, string searchPattern)
    {
        var files = new string[]
        {
            "TestFile1.txt",
            "AnotherTestFile.txt",
            "NoMatchFile.txt"
        };

        return files.Where(file => file.Contains(searchPattern, StringComparison.OrdinalIgnoreCase)).ToArray();
    }
}
