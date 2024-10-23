namespace Test.Domain.Base.Entities;

public class EntityTests
{
    private static readonly TestEntity TestEntityOne = TestEntity.Create(1, "test");
    private static readonly TestEntity TestEntityTwo = TestEntity.Create(2, "test");
    
    [Test]
    public void Equals_HappyPath()
    {
        // Arrange
        var testEntity = TestEntity.Create(1, "test");
        
        // Act
        var result = TestEntityOne.Equals(testEntity);
        
        // Assert
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void Equals_SameEntity()
    {
        // Act
        var result = TestEntityOne.Equals(TestEntityOne);
        
        // Assert
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void Equals_NullEntity()
    {
        // Act
        var result = TestEntityOne.Equals(null);
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void Equals_DifferentEntity()
    {
        // Act
        var result = TestEntityOne.Equals(TestEntityTwo);
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void Equals_DifferentType()
    {
        // Act
        var result = TestEntityOne.Equals(new object());
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void GetHashCode_HappyPath()
    {
        // Act
        var result = TestEntityOne.GetHashCode();
        
        // Assert
        Assert.That(result, Is.EqualTo(TestEntityOne.Id.GetHashCode()));
    }
    
    [Test]
    public void GetHashCode_DifferentEntity()
    {
        // Act
        var result = TestEntityOne.GetHashCode();
        
        // Assert
        Assert.That(result, Is.Not.EqualTo(TestEntityTwo.GetHashCode()));
    }
}