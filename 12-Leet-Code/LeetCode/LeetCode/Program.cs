using System;
using static LeetCode.ContainsDuplicate;

namespace LeetCode
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var arrays = new[]
            {
                new[] { 1, 2, 3, 1 },
                new[] { 1, 2, 3, 4 },
                new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }
            };

            foreach (var array in arrays)
            {
                var hasDuplicate = CheckForDuplicates(array);
                Console.WriteLine($"List of numbers [{string.Join(", ", array)}] contains duplicate? {hasDuplicate}");
            }

            Console.ReadKey();
        }
    }
}
