//https://leetcode.com/problems/valid-anagram/
public class Solution9 {
    public bool IsAnagram(string s, string t)
    {
        var buff = new int['z'-'a'+1];
        var indexBuff = new int[s.Length];
        
        if (s.Length != t.Length) return false;
        
        for (var i = 0; i < s.Length; i++)
        {
            buff[s[i] - 'a']++;
            buff[t[i] - 'a']--;
            indexBuff[i] = s[i] - 'a';
        }

        for (var i = 0; i < indexBuff.Length; i++)
        {
            if (buff[indexBuff[i]]!=0)
            {
                return false;
            }
        }
        return true;
    }
}