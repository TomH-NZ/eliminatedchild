namespace EliminatedChild;

public class Child : IChild
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
}