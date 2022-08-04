using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 4, 6, 7, 3, 8, -1, 5 };
            Console.WriteLine(Min(nums));

            static int Min(int[] nums)
            {
                int num = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i - 1] > nums[i])
                    {

                        num = nums[i];
                    }
                    
                }
                return num;
            }
        }
    }
}

