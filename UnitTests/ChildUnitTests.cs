using EliminatedChild;

namespace UnitTests;

public class ChildUnitTests
{
    [Fact]
    public void GivenATotal_WhenCreatingAList_TheCorrectListOfChildrenIsReturned()
    {
        //Arrange
        const int childData = 2;
        var childList = new ChildList();
        
        //Act
        var expected = new List<string>{"Child 1", "Child 2"};
        var result = childList.ListToUse(childData);

        //Assert
        Assert.Equal(expected, result);
    }
}