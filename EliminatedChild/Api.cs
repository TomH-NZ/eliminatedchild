using System.Text.Json.Nodes;

namespace EliminatedChild;

//URL = "https://7annld7mde.execute-api.ap-southeast2.amazonaws.com/main/game"

public class Api : IApi
{
    public DataObject GetChildDataAsync()
    {
        
        DataObject childData = new()
            {
            Id = 1,
            ChildCount = 4,
            EliminatedChild = 4
        };

        return childData;
    }
}
