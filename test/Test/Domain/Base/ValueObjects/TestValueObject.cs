using Domain.Base;

namespace Test.Domain.Base.ValueObjects;

public class TestValueObject : ValueObject
{
    public string Test { get; }
    
    private TestValueObject(string test)
    {
        Test = test;
    }
    
    public static TestValueObject Create(string test)
    {
        return new TestValueObject(test);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Test;
    }
}