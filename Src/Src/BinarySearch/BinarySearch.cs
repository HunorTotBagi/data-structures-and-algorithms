namespace Src.BinarySearch;

public class BinarySearch
{
    public static int BasicBinarySearch(int[] array, int target)
    {
        var start = 0;
        var end = array.Length;

        while (start < end)
        {
            int middle = start + (end - start) / 2;

            if (target < array[middle])
                end = middle - 1;
            else if (target > array[middle])
                start = middle + 1;
            else
                return middle;
        }

        return -1;
    }
}
