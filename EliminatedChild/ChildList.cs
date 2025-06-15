namespace EliminatedChild;

public class ChildList : IChildList
{
    public List<string> ListToUse(int childTotal)
    {
        var childList = new List<string>();

        for (var count = 1; count <= childTotal; count++)
        {
            childList.Add($"Child {count}");
        }
        return childList;
    }

    public List<string> eliminatedChildrenList = new List<string>();
}