using Moq;

namespace Test.Domain.Base.ValueObjects;

public class ValueObjectTests
{
    private static readonly TestValueObject ValueObjectTestOne = TestValueObject.Create("one");
    private static readonly TestValueObject ValueObjectTestTwo = TestValueObject.Create("two");

    [Test]
    public void Equals_HappyPath()
    {
        // Arrange
        var valueObjectOne = TestValueObject.Create("one");
        
        // Act
        var result = ValueObjectTestOne.Equals(valueObjectOne);
        
        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Equals_EqualReference()
    {
        // Arrange
        var objectOne = TestValueObject.Create("one");
        
        // Act
        var result = ValueObjectTestOne.Equals(ValueObjectTestOne);
        
        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Equals_NullReference()
    {
        // Arrange
        var nullObject = It.IsAny<TestValueObject>();
        
        // Act
        var result = ValueObjectTestOne.Equals(nullObject);
        
        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Equals_NotEquals()
    {
        // Act
        var result = ValueObjectTestOne.Equals(ValueObjectTestTwo);
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void EqualsObject_HappyPath()
    {
        // Arrange
        object objectTwo = TestValueObject.Create("one");
        
        // Act
        var result = ValueObjectTestOne.Equals(objectTwo);
        
        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void EqualsObject_NullReference()
    {
        // Arrange
        var nullObject = It.IsAny<object>();
        
        // Act
        var result = ValueObjectTestOne.Equals(nullObject);
        
        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void EqualsObject_InvalidType()
    {
        // Arrange
        var invalidObjectType = new { Invalid = "test" };
        
        // Act
        var result = ValueObjectTestOne.Equals(invalidObjectType);
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void EqualsObject_NotEquals()
    {
        // Act
        var result = ValueObjectTestOne.Equals(ValueObjectTestTwo);
        
        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void GetHashCode_HappyPath()
    {
        // Act
        var hashCodeOne = ValueObjectTestOne.GetHashCode();
        var hashCodeTwo = ValueObjectTestOne.GetHashCode();
        
        // Assert
        Assert.That(hashCodeOne, Is.EqualTo(hashCodeTwo));
    }
    
    [Test]
    public void GetHashCode_DifferentHashCodes()
    {
        // Act
        var hashCodeOne = ValueObjectTestOne.GetHashCode();
        var hashCodeTwo = ValueObjectTestTwo.GetHashCode();
        
        // Assert
        Assert.That(hashCodeOne, Is.Not.EqualTo(hashCodeTwo));
    }
    
    [Test]
    public void OperatorEquals_HappyPath()
    {
        // Arrange
        var valueObjectOne = TestValueObject.Create("one");
        
        // Act
        var result = ValueObjectTestOne == valueObjectOne;
        
        // Assert
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void OperatorEquals_NotEquals()
    {
        // Act
        var result = ValueObjectTestOne == ValueObjectTestTwo;
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void OperatorEquals_NullReferences()
    {
        // Arrange
        var nullObjectOne = It.IsAny<TestValueObject>();
        var nullObjectTwo = It.IsAny<TestValueObject>();
        
        // Act
        var result = nullObjectOne == nullObjectTwo;
        
        // Assert
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void OperatorEquals_LeftIsNull()
    {
        // Act
        var result = It.IsAny<TestValueObject>() == ValueObjectTestOne;
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void OperatorEquals_RightIsNull()
    {
        // Act
        var result = ValueObjectTestOne == It.IsAny<TestValueObject>();
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void OperatorNotEquals_HappyPath()
    {
        // Arrange
        var valueObjectOne = TestValueObject.Create("one");
        
        // Act
        var result = ValueObjectTestOne != valueObjectOne;
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void OperatorNotEquals_NotEquals()
    {
        // Act
        var result = ValueObjectTestOne != ValueObjectTestTwo;
        
        // Assert
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void OperatorNotEquals_NullReferences()
    {
        // Arrange
        var nullObjectOne = It.IsAny<TestValueObject>();
        var nullObjectTwo = It.IsAny<TestValueObject>();
        
        // Act
        var result = nullObjectOne != nullObjectTwo;
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void OperatorNotEquals_LeftIsNull()
    {
        // Act
        var result = It.IsAny<TestValueObject>() != ValueObjectTestOne;
        
        // Assert
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void OperatorNotEquals_RightIsNull()
    {
        // Act
        var result = ValueObjectTestOne != It.IsAny<TestValueObject>();
        
        // Assert
        Assert.That(result, Is.True);
    }
}