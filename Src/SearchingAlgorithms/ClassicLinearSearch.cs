namespace Src.SearchingAlgorithms;

public class ClassicLinearSearch
{
    public static int LinearSearch(int[] array, int target)
    {
        if (array.Length == 0)
            return -1;

        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
                return i;
        }

        return -1;
    }
}
