using System;
using System.Diagnostics;

class TwoSum
{
    public static int[] twoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == target - nums[i])
                {
                    return new int[] { i, j };
                }
            }
        }
        return null;
    }

    static void Main()
    {
        Console.WriteLine(string.Join(",", twoSum(new int[4] { 2, 7, 11, 15 }, 18)));
    }
}