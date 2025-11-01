
public class Algorithms
{
    public static List<T> Reverse<T>(List<T> inputList)
    {
        List<T> reversedList = new List<T>();

        for (int i = inputList.Count - 1; i >= 0; i--)
        {
            reversedList.Add(inputList[i]);
        }

        return reversedList;
    }

    public static List<T> Sort<T>(List<T> inputList)
        where T : IComparable<T>
    {
        List<T> sortedList = new List<T>(inputList);
        int n = sortedList.Count;

        T temp;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (sortedList[j].CompareTo(sortedList[j + 1]) > 0)
                {
                    temp = sortedList[j];
                    sortedList[j] = sortedList[j + 1];
                    sortedList[j + 1] = temp;
                }
            }
        }

        return sortedList;
    }

    public static bool Any(List<int> inputList)
    {
        for (int i = 0; i < inputList.Count; i++)
        {
            if (inputList[i] == 10)
            {
                return true;
            }
        }

        return false;
    }

    public static bool All(List<int> inputList)
    {
        List<int> forCompare = new() { 1, 2, 3, 4, 5 };

        if (inputList.Count != forCompare.Count)
            return false;

        for (int i = 0; i < inputList.Count; i++)
        {
            if (inputList[i] != forCompare[i])
            {
                return false;
            }
        }

        return true;
    }

    public static int FirstOrDefault(List<int> inputList)
    {
        for (int i = 0; i < inputList.Count; i++)
        {
            if (inputList[i] == 10)
            {
                return inputList[i];
            }
        }

        return default;
    }

    public static int LastOrDefault(List<int> inputList)
    {
        for (int i = inputList.Count - 1; i >= 0; i++)
        {
            if (inputList[i] == 10)
            {
                return inputList[i];
            }
        }

        return default;
    }

    public static int FindIndex(List<int> inputList)
    {
        for (int i = 0; i < inputList.Count; i++)
        {
            if (inputList[i] == 10)
            {
                return i;
            }
        }

        return -1;
    }

    public static int FindLastIndex(List<int> inputList)
    {
        for (int i = inputList.Count - 1; i >= 0; i++)
        {
            if (inputList[i] == 10)
            {
                return i;
            }
        }

        return -1;
    }

    public static int SumAllElements(List<int> inputList)
    {
        int sum = 0;
        for (int i = inputList.Count - 1; i >= 0; i++)
        {
            sum += inputList[i];
        }

        return sum;
    }
}

