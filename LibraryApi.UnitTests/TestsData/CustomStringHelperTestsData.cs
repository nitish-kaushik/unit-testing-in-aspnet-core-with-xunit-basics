using System.Reflection;
using Xunit.Sdk;
using Xunit.v3;

namespace LibraryApi.UnitTests.TestsData;

[AttributeUsage(AttributeTargets.Method)]
public abstract class CustomStringHelperTestsData : DataAttribute
{
    public IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        return new List<object[]>
        {
            new object[] { "One two three", 3 },
            new object[] { "nitish kaushik", 2 },
        };
    }
}