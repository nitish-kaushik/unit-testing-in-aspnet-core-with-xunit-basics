namespace LibraryApi.UnitTests.Helpers;

public class AssertTests
{
    [Fact]
    public void Boolean_Assert_Returns_True()
    {
        // Arrange
        bool condition = true;
        int a = 10;

        // Act & Assert
        Assert.False(a > 10, "test message");
    }

    [Fact(Skip = "This test is skipped for demonstration purposes.")]
    public void Equality_Assert()
    {
        var firstList = new List<int>() { 1, 2, 3 };
        var secondList = new List<int>() { 1, 2, 3 };

        Assert.Equal(firstList, secondList);
        //Assert.NotEqual(3, firstNum);

        Assert.StrictEqual(firstList, secondList);
        //Assert.NotStrictEqual(3, firstNum);
    }

    [Fact]
    public void Identity_Assert()
    {
        var firstList = new List<int>() { 1, 2, 3 };
        var secondList = new List<int>() { 1, 2, 3 };
        var thirdList = firstList;

        //Assert.Same(firstList, thirdList);
        Assert.NotSame(firstList, secondList);
    }

    [Fact]
    public void Null_Assert()
    {
        string? data = "";
        Assert.NotNull(data);
    }

    [Fact]
    public void String_Assert()
    {
        string? data = "Hello, World!";

        Assert.StartsWith("Hello", data);
        Assert.EndsWith("World!", data);
        Assert.Contains("lo, Wo", data);
        Assert.DoesNotContain("nitish", data);
        Assert.Equal("Hello, World!", data);
        Assert.Matches(@"Hello, World!", data);
    }

    [Fact]
    public void Collection_Assert()
    {
        var collection = new List<int>() { 1, 2, 3, 3, 4, 5 };

        // Assert.Contains(3, collection);
        // Assert.DoesNotContain(6, collection);
        // Assert.All(collection, item => Assert.True(item > 0));
        // Assert.Distinct(collection);
        // Assert.Empty(new string(""));
        // Assert.NotEmpty(collection);
        //Assert.Single(collection, item => item == 3);
        Assert.Collection(collection,
            item => Assert.Equal(1, item),
            item => Assert.Equal(2, item),
            item => Assert.Equal(3, item),
            item => Assert.Equal(3, item),
            item => Assert.Equal(4, item),
            item => Assert.Equal(5, item)
        );
    }

    [Fact]
    public void Skip_Assert()
    {
        var condition = true;
        Assert.SkipWhen(condition, "This test is skipped for demonstration purposes.");
        Assert.SkipUnless(!condition, "This test is skipped for demonstration purposes.");
    }
}