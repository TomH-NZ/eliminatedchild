
namespace EliminatedChild;

public class Process
{
    static DataObject _childData = new Api().GetChildDataAsync();
    static ChildList _child = new();

    int _childToRemove = _childData.EliminatedChild;
    int startingChild;
    List<string> _childrenToEliminate = _child.ListToUse(_childData.ChildCount);

    public void RemoveChild()
    {
        while (_childrenToEliminate.Count > 1)
        {
            var eliminationCount = _childToRemove % _childrenToEliminate.Count;

            if (startingChild + eliminationCount > _childrenToEliminate.Count)
            {
                startingChild = startingChild + eliminationCount - _childrenToEliminate.Count;
                
            }

            if (eliminationCount < _childrenToEliminate.Count)
            {
                _child.EliminatedChildrenList.Add(_childrenToEliminate[eliminationCount]);
                _childrenToEliminate.RemoveAt(eliminationCount);
                startingChild = eliminationCount + 1;
            }
        }
        
        Console.WriteLine($"The game is {_childData.Id}");
        Console.WriteLine($"The winning child is {_childrenToEliminate[0]}");
    }
    
    //ToDo
    //Add unit tests.
    //Add working API.
}