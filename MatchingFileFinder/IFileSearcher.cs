namespace MatchingFileFinder;

public interface IFileSearcher
{
    string[] SearchFiles(string directoryPath, string searchPattern);
}


public class FileSearcherStub : IFileSearcher
{
    public string[] SearchFiles(string directoryPath, string searchPattern)
    {
        // Заглушка возвращает фиксированный набор файлов для тестирования
        var files = new string[]
        {
            "TestFile1.txt",
            "AnotherTestFile.txt",
            "NoMatchFile.txt"
        };

        // Фильтрация файлов по шаблону поиска
        return files.Where(file => file.Contains(searchPattern, StringComparison.OrdinalIgnoreCase)).ToArray();
    }
}
