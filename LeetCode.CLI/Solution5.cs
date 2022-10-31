//https://leetcode.com/problems/plus-one/
public class Solution5 {
    public int[] PlusOne(int[] digits)
    {
        for (var i = digits.Length-1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        
        digits = new int[digits.Length+1];
        digits[0] = 1;
        return digits;
    }
    public int[] PlusOne2(int[] digits) {
        int rem = 1;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int temp = digits[i];
            digits[i] = (digits[i] + rem) % 10;
            rem = (temp + rem) / 10;
        }
        if (rem == 1)
        {
            int[] result = new int[digits.Length + 1];
            digits.CopyTo(result, 1);
            result[0] = rem;
            return result;    
        }
        return digits;
    }
}