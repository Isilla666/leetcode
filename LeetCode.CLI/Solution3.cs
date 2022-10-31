//https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class Solution3 {
    public int RemoveDuplicates(ref int[] nums)
    {
        var index = 0;
        bool flag;
        for (var i = 1; i < nums.Length; i++)
        {
            flag = true;
            for (var j = 0; j <= index; j++)
            {
                if (nums[i] == nums[j])
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                index++;
                nums[index] = nums[i];
            }
        }
        return index + 1;
    }
}