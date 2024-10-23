using Domain.Base;

namespace Test.Domain.Base.Entities;

public class TestEntity : Entity<int>
{
    public string Test { get; set; }

    private TestEntity(int id, string test) : base(id)
    {
        Test = test;
    }
    
    public static TestEntity Create(int id, string test)
    {
        return new TestEntity(id, test);
    }
}