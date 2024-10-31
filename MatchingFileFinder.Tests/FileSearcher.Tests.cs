namespace MatchingFileFinder.Tests;

[TestFixture]
public class FileSearcherTests
{
    [Test]
    public void SearchFiles_ShouldFindMatchingFiles()
    {
        IFileSearcher fileSearcher = new FileSearcherStub();
        string searchPattern = "Test";

        var result = fileSearcher.SearchFiles("", searchPattern);

        Assert.AreEqual(2, result.Length);
    }

    [Test]
    public void SearchFiles_ShouldNotFindNonMatchingFiles()
    {
        IFileSearcher fileSearcher = new FileSearcherStub();
        string searchPattern = "NoMatch";

        var result = fileSearcher.SearchFiles("", searchPattern);

        Assert.AreEqual(1, result.Length);
    }
}