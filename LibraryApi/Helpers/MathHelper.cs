namespace LibraryApi.Helpers;

public class MathHelper
{
    public int Add(int? a, int? b)
    {
        if (a == null || b == null)
        {
            throw new ArgumentNullException("Data is null");
        }

        if (a == 0 || b == 0)
        {
            throw new ArgumentException("Data is zero");
        }

        return a.Value + b.Value;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero");

        return (double)a / b;
    }

    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public int Max(int a, int b)
    {
        return a > b ? a : b;
    }
}