using System;
using System.Collections.Generic;

namespace ShuffleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 5, 1, 3, 4, 7 };
            Console.WriteLine(ShuffleArray(nums, 3));
            Console.ReadLine();
        }
        public static int[] ShuffleArray(int[] nums,int n)
        {
            List<int> res = new List<int>();
            int j = n;
            for(int i=0;i<n;i++)
            {
                res.Add(nums[i]);
                res.Add(nums[j]);
                j++;
            }
            return res.ToArray();
        }
    }
}
