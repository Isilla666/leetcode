using System.Diagnostics;
//https://leetcode.com/problems/two-sum/
public class Solution1 
{
    public static void main()
    {
        Console.WriteLine("Hello");
    }
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length-2; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new[] { i, j };
                }
            }
        }
        return new []{nums.Length-2,nums.Length-1};
    }
}