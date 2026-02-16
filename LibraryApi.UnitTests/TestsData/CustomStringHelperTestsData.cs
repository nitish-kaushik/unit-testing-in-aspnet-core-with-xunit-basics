using System.Reflection;
using Xunit.Sdk;

namespace LibraryApi.UnitTests.TestsData;

[AttributeUsage(AttributeTargets.Method)]
public class CustomStringHelperTestsData : DataAttribute
{
    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        return new List<object[]>
        {
            new object[] { "One two three", 3 },
            new object[] { "nitish kaushik", 2 },
        };
    }
}