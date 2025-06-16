
namespace EliminatedChild;

public class Process 
{
    public void RemoveChild(DataObject childData, IChildList childList)
    {
        
        var listToRemoveFrom = childList.ListToUse(childData.ChildCount);
        var eliminatedChildrenList = childList.EliminatedChildrenList();
        var childToRemove = childData.EliminatedChild;
        var startingChild = 0;
        
        while (listToRemoveFrom.Count > 1)
        {
            var childrenToCountThrough = childToRemove % listToRemoveFrom.Count;

            if (startingChild + childrenToCountThrough > listToRemoveFrom.Count)
            {
                startingChild = startingChild + childrenToCountThrough - listToRemoveFrom.Count;
                
            }

            if (childToRemove % listToRemoveFrom.Count == 0)
            {
                eliminatedChildrenList.Add(listToRemoveFrom[^1]);
                listToRemoveFrom.RemoveAt(listToRemoveFrom.Count - 1);
                startingChild = 0;
            }

            else if (childrenToCountThrough < listToRemoveFrom.Count)
            {
                eliminatedChildrenList.Add(listToRemoveFrom[childrenToCountThrough - 1]);
                listToRemoveFrom.RemoveAt(childrenToCountThrough - 1);
                startingChild = childrenToCountThrough + 1;
            }
        }
        
        Console.WriteLine($"The game is {childData.Id}");
        Console.WriteLine($"The winning child is {listToRemoveFrom[0]}");
    }
    
    //ToDo
    //Add unit tests.
    //Add working API.
}