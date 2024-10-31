namespace MatchingFileFinder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the directory path:");
        string directoryPath = Console.ReadLine();

        Console.WriteLine("Enter the search pattern:");
        string searchPattern = Console.ReadLine();

        IFileSearcher fileSearcher = new FileSearcher();
        try
        {
            string[] files = fileSearcher.SearchFiles(directoryPath, searchPattern);
            Console.WriteLine("Found files:");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}