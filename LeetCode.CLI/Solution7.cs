//https://leetcode.com/problems/roman-to-integer/

using System.Diagnostics;

public class Solution7 {
    
    public int RomanToInt(string s)
    {
        var chars = new []{ 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        var nums = new []{ 1, 5, 10, 50, 100, 500, 1000 };
        var sum = 0;
        var current = 0;
        
        for (var j = 0; j < chars.Length; j++)
        {
            if (s[0] == chars[j])
            {
                current = nums[j];
                break;
            }
        }
        for (var i = 0; i < s.Length; i++)
        {
            if (i == (s.Length - 1))
            {
                sum += current;
                break;
            }

            var next = 0;
            for (var j = 0; j < chars.Length; j++)
            {
                if (s[i+1] == chars[j])
                {
                    next = nums[j];
                    break;
                }
            }
            if (next>current)
            {
                sum += next - current;
                i++;
                if (i == (s.Length-1))
                {
                    break;
                }
                for (var j = 0; j < chars.Length; j++)
                {
                    if (s[i+1] == chars[j])
                    {
                        current = nums[j];
                        break;
                    }
                }
            }
            else
            {
                sum += current;
                current = next;
            }
        }
        return sum;
    }
}