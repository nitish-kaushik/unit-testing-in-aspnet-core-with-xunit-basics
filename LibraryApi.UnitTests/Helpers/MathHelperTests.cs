using LibraryApi.Helpers;

namespace LibraryApi.UnitTests.Helpers;

public class MathHelperTests(ITestOutputHelper outputHelper)
{
    private readonly MathHelper _mathHelper = new();

    [Fact]
    [Trait("category", "addition")]
    [Trait("bug", "abc-123")]
    public void Add_WithTwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 10;

        // Act
        var result = _mathHelper.Add(a, b);
        outputHelper.WriteLine("Adding {0} and {1} gives {2}", a, b, result);
        // Assert
        Assert.True(result > 0);
        Assert.Equal(15, result);
    }

    [Fact]
    [Trait("category", "addition")]
    public void Add_WithNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = -5;
        int b = -10;

        // Act
        var result = _mathHelper.Add(a, b);
        outputHelper.WriteLine("Adding {0} and {1} gives {2}", a, b, result);

        // Assert
        Assert.Equal(-15, result);
    }

    [Fact]
    [Trait("category", "add")]
    public void Add_WithZeroValues_ReturnsCorrectSum()
    {
        // Arrange
        int a = 0;
        int b = 0;

        // Act
        var result = _mathHelper.Add(a, b);

        // Assert
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(5, 5, 10)]
    [InlineData(-5, 5, 0)]
    [InlineData(100, 200, 300)]
    [InlineData(-100, -200, -300)]
    public void Add_WithVariousInputs_ReturnsCorrectSum(int a, int b, int expected)
    {
        // Act
        var result = _mathHelper.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(10, 7, 3)]
    [InlineData(0, 5, -5)]
    [InlineData(-5, -3, -2)]
    [InlineData(100, 50, 50)]
    [Trait("category", "subtraction")]
    public void Subtract_WithVariousInputs_ReturnsCorrectDifference(int a, int b, int expected)
    {
        // Act
        var result = _mathHelper.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Subtract_SameNumbers_ReturnsZero()
    {
        // Arrange
        int a = 42;
        int b = 42;

        // Act
        var result = _mathHelper.Subtract(a, b);

        // Assert
        Assert.Equal(0, result);
    }


    [Theory]
    [InlineData(5, 3, 15)]
    [InlineData(10, 0, 0)]
    [InlineData(-5, 3, -15)]
    [InlineData(-5, -3, 15)]
    [InlineData(7, 7, 49)]
    public void Multiply_WithVariousInputs_ReturnsCorrectProduct(int a, int b, int expected)
    {
        // Act
        var result = _mathHelper.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Multiply_ByOne_ReturnsSameNumber()
    {
        // Arrange
        int a = 25;
        int b = 1;

        // Act
        var result = _mathHelper.Multiply(a, b);

        // Assert
        Assert.Equal(25, result);
    }


    [Fact]
    public void Divide_WithValidDivisor_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = 10;
        int b = 2;

        // Act
        var result = _mathHelper.Divide(a, b);

        // Assert
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Divide_WithZeroDivisor_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        var exception = Assert.Throws<DivideByZeroException>(() => _mathHelper.Divide(a, b));
        Assert.Equal("Cannot divide by zero", exception.Message);
    }

    [Theory]
    [InlineData(10, 3, 3.333333333333333)]
    [InlineData(7, 2, 3.5)]
    [InlineData(-10, 2, -5.0)]
    [InlineData(20, 4, 5.0)]
    [InlineData(9, 3, 3.0)]
    public void Divide_WithVariousInputs_ReturnsCorrectDecimalQuotient(int a, int b, double expected)
    {
        // Act
        var result = _mathHelper.Divide(a, b);

        // Assert
        Assert.Equal(expected, result, 10); // precision to 10 decimal places
    }

    [Fact]
    public void Divide_NegativeByPositive_ReturnsNegativeQuotient()
    {
        // Arrange
        int a = -20;
        int b = 4;

        // Act
        var result = _mathHelper.Divide(a, b);

        // Assert
        Assert.Equal(-5.0, result);
    }


    [Theory]
    [InlineData(2, true)]
    [InlineData(4, true)]
    [InlineData(0, true)]
    [InlineData(101, false)]
    public void IsEven_WithVariousNumbers_ReturnsCorrectResult(int number, bool expected)
    {
        // Act
        var result = _mathHelper.IsEven(number);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void IsEven_WithLargeEvenNumber_ReturnsTrue()
    {
        // Arrange
        int number = 1000000;

        // Act
        var result = _mathHelper.IsEven(number);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(5, 3, 5)]
    [InlineData(3, 5, 5)]
    [InlineData(0, -10, 0)]
    [InlineData(100, 99, 100)]
    public void Max_WithVariousInputs_ReturnsMaximumValue(int a, int b, int expected)
    {
        // Act
        var result = _mathHelper.Max(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Max_WithBothNegativeNumbers_ReturnsLesserNegative()
    {
        // Arrange
        int a = -10;
        int b = -20;

        // Act
        var result = _mathHelper.Max(a, b);

        // Assert
        Assert.Equal(-10, result);
    }

    [Fact]
    public void Max_WithZeroAndPositive_ReturnsPositive()
    {
        // Arrange
        int a = 0;
        int b = 5;

        // Act
        var result = _mathHelper.Max(a, b);

        // Assert
        Assert.Equal(5, result);
    }
}