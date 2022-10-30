public class Solution2 
{
    public int RemoveElement(ref int[] nums, int val)
    {
        var index = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                continue;
            }
            nums[index] = nums[i];
            index++;
        }
        return index;
    }
}