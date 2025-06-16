using EliminatedChild;

namespace UnitTests;

public class EliminationTests
{
    IChildList childList = new ChildList();
    static IApi childApi = new Api();

    private DataObject childData = childApi.GetChildDataAsync();
    
    
}