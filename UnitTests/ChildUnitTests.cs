using EliminatedChild;

namespace UnitTests;

public class ChildUnitTests
{
    [Fact]
    public void GivenANumber_WhenCreatingAList_AListOfChildrenIsReturned()
    {
        //Arrange
        var childData = 2;
        var childList = new Child();
        
        //Act
        var expected = new List<string>{"Child 1", "Child 2"};
        var result = childList.ListToUse(childData);

        //Assert
        Assert.Equal(expected, result);
    }
}