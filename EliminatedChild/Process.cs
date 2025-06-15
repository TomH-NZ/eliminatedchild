
namespace EliminatedChild;

public class Process
{
    static DataObject _childData = new Api().GetChildDataAsync();
    static ChildList _childList = new();

    int _childToRemove = _childData.EliminatedChild;
    int _startingChild;
    List<string> _listToRemoveFrom = _childList.ListToUse(_childData.ChildCount);

    public void RemoveChild()
    {
        while (_listToRemoveFrom.Count > 1)
        {
            var childrenToCountThrough = _childToRemove % _listToRemoveFrom.Count;

            if (_startingChild + childrenToCountThrough > _listToRemoveFrom.Count)
            {
                _startingChild = _startingChild + childrenToCountThrough - _listToRemoveFrom.Count;
                
            }

            if (_childToRemove % _listToRemoveFrom.Count == 0)
            {
                _childList.EliminatedChildrenList.Add(_listToRemoveFrom[^1]);
                _listToRemoveFrom.RemoveAt(_listToRemoveFrom.Count - 1);
                _startingChild = 0;
            }

            else if (childrenToCountThrough < _listToRemoveFrom.Count)
            {
                _childList.EliminatedChildrenList.Add(_listToRemoveFrom[childrenToCountThrough - 1]);
                _listToRemoveFrom.RemoveAt(childrenToCountThrough - 1);
                _startingChild = childrenToCountThrough + 1;
            }
        }
        
        Console.WriteLine($"The game is {_childData.Id}");
        Console.WriteLine($"The winning child is {_listToRemoveFrom[0]}");
    }
    
    //ToDo
    //Add unit tests.
    //Add working API.
}