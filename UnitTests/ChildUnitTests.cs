using EliminatedChild;

namespace UnitTests;

public class ChildUnitTests
{
    private ChildList _childList = new();
    
    [Fact]
    public void GivenATotal_WhenCreatingAList_TheCorrectListOfChildrenIsReturned()
    {
        //Arrange
        const int childData = 2;
        
        //Act
        var expected = new List<string>{"Child 1", "Child 2"};
        var result = _childList.ListToUse(childData);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GivenABlankList_WhenAddingAChild_TheCorrectLengthIsReturned()
    {
        //Arrange
        
        //Act
        _childList.EliminatedChildrenList.Add("Child 1");
        
        //Assert
        Assert.Single(_childList.EliminatedChildrenList);
    }

    [Theory]
    [MemberData(nameof(ChildTestData))]
    public void GivenABlankList_WhenAddingAChild_ThenCorrectCountIsReturned(List<string> result, int expected)
    {
        //Arrange
        
        //Act
        
        //Assert
        Assert.Equal(result.Count, expected);
    }
    

    public static IEnumerable<object[]> ChildTestData =>
        new List<object[]>
        {
            new object [] {new List<string>{"Child 1"},1},
            new object [] {new List<string>{"Child 1", "Child 2", "Child 3"}, 3},
            new object [] {new List<string>{"Child 2", "Child 4", "Child 10", "Child 20"}, 4}
        };
}