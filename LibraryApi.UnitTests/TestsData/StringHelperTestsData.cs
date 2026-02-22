using System.Collections;

namespace LibraryApi.UnitTests.TestsData;

public class StringHelperTestsData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [GetName(), 5];
        yield return ["One two three", 3];
        yield return ["One two three four", 4];
    }
    
    private static string GetName()
    {
        return "One two three four five";
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class StringHelperTestsData1 : TheoryData<string, int>
{
    public StringHelperTestsData1()
    {
        Add("One two three", 3);
        Add("One two three four", 4);
    }
    
    private static string GetName()
    {
        return "One two three four five";
    }
}