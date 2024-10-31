namespace MatchingFileFinder;

public class FileSearcher : IFileSearcher
{
    public string[] SearchFiles(string directoryPath, string searchPattern)
    {
        if (string.IsNullOrEmpty(directoryPath) || string.IsNullOrEmpty(searchPattern))
        {
            throw new ArgumentException("Directory path and search pattern must not be empty.");
        }

        if (!Directory.Exists(directoryPath))
        {
            throw new DirectoryNotFoundException($"Directory {directoryPath} not found.");
        }

        return Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories)
            .Where(file => Path.GetFileName(file).Contains(searchPattern, StringComparison.OrdinalIgnoreCase))
            .ToArray();
    }
}
