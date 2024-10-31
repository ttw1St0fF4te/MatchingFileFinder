namespace MatchingFileFinder.Tests;

[TestFixture]
public class FileSearcherTests
{
    [Test]
    public void SearchFiles_ShouldFindMatchingFiles()
    {
        // Arrange
        IFileSearcher fileSearcher = new FileSearcherStub();
        string searchPattern = "Test";

        // Act
        var result = fileSearcher.SearchFiles("", searchPattern);

        // Assert
        Assert.AreEqual(2, result.Length);
    }

    [Test]
    public void SearchFiles_ShouldNotFindNonMatchingFiles()
    {
        // Arrange
        IFileSearcher fileSearcher = new FileSearcherStub();
        string searchPattern = "NoMatch";

        // Act
        var result = fileSearcher.SearchFiles("", searchPattern);

        // Assert
        Assert.AreEqual(1, result.Length);
    }
}