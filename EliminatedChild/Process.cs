namespace EliminatedChild;

public class Process
{
    static Data _data = new Api().GetChildDataAsync();
    static ChildList _child = new ChildList();
    List<string> _eliminatedChildrenList = [];

    int _childToRemove = _data.EliminatedChild;
    int startingChild;
    List<string> _childrenToEliminate = _child.ListToUse(_data.ChildCount);

    public void RemoveChild()
    {
        while (_childrenToEliminate.Count > 1)
        {
            //ToDo
            //Add logic to remove child at childToRemove, set startingChild to be the next child in the list, add removed child to eliminatedChildList.
            //Use modulus for calculation, print remainder at end.
            //Add unit tests.
            //Add working API.
        }
    }
}