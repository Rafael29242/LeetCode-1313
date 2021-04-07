using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode1313
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Join(", ", RLEListDecompression(new int[] { 4, 5, 4, 10, 2, 5})));
            Console.WriteLine(string.Join(", ", RLEListDecompression(new int[] { 1, 1, 1, 2, 1, 3, 1, 4, 1, 5})));
            Console.WriteLine(string.Join(", ", RLEListDecompression(new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 })));
            Console.WriteLine(string.Join(", ", RLEListDecompression(new int[] { 5, 1, 4, 2, 3, 3, 2, 4, 1, 5})));


        }

        static int[] RLEListDecompression(int[] nums)
        {
            var results = new List<int>();

            for (int i = 0; i < nums.Length; i += 2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    results.Add(nums[i + 1]);
                }
            }

            return results.ToArray();
        }

    }
}
