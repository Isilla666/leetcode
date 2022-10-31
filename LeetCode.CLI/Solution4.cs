//https://leetcode.com/problems/search-insert-position/
public class Solution4
{
    public int SearchInsert(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target)
            {
                return i;
            }
        }
        return nums.Length;
    }
}