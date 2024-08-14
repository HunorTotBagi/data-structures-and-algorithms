using System.Collections.Generic;

namespace LeetCode
{
    public static class ContainsDuplicate
    {
        public static bool CheckForDuplicates(int[] array)
        {
            var seenNumbers = new HashSet<int>(array.Length);

            foreach (int element in array)
            {
                if (seenNumbers.Contains(element))
                {
                    return true;
                }
                seenNumbers.Add(element);
            }
            return false;
        }
    }
}