using LibraryApi.Helpers;
using LibraryApi.UnitTests.TestsData;

namespace LibraryApi.UnitTests.Helpers;

public class StringHelperTests : IDisposable
{
    private readonly StringHelper _stringHelper;

    public StringHelperTests()
    {
        _stringHelper = new StringHelper();
    }

    [Fact]
    public void IsEmpty_WithEmptyString_ReturnsTrue()
    {
        // Act
        var result = _stringHelper.IsEmpty(string.Empty);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEmpty_WithNullString_ReturnsTrue()
    {
        // Act
        var result = _stringHelper.IsEmpty(null);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEmpty_WithValidString_ReturnsFalse()
    {
        // Arrange
        var stringHelper = new StringHelper();

        // Act
        var result = stringHelper.IsEmpty("nitish");

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData("Nitish", 1)]
    [InlineData("Nitish Kumar", 2)]
    [InlineData("  Leading and trailing spaces  ", 4)]
    [InlineData("", 0)]
    [MemberData(nameof(GetData))]
    [ClassData(typeof(StringHelperTestsData1))]
    public void CountWords_WithMultipleWords_ReturnsCorrectCount(string text, int expectedCount)
    {
        // Act
        var result = _stringHelper.CountWords(text);

        // Assert
        Assert.Equal(expectedCount, result);
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return [GetName(), 5];
        yield return ["One two three", 3];
        yield return ["One two three four", 4];
    }

    private static string GetName()
    {
        return "One two three four five";
    }

    public void Dispose()
    {
        // Cleanup if needed
    }
}