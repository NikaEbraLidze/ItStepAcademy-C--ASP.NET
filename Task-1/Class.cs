public delegate List<T> ListProcessor<T>(List<T> sourceList);

public delegate bool FindDelegate(List<int> sourceList);

public delegate int NumOrDefDelegate(List<int> sourceList);

public static class ListUtils
{
    public static List<T> DelegateExecutor<T>(List<T> sourceList, ListProcessor<T> listProcessor)
    {
        return listProcessor(sourceList);
    }

    public static bool CompareEmelemts(List<int> sourceList, FindDelegate findDelegate)
    {
        return findDelegate(sourceList);
    }

    public static int CompareEmelemts(List<int> sourceList, NumOrDefDelegate numOrDefDelegate)
    {
        return numOrDefDelegate(sourceList);
    }
}