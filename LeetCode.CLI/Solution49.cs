//https://leetcode.com/problems/group-anagrams/description/
public class Solution49 {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var indexes = new Dictionary<string, int>();
        var output = new List<IList<string>>();

        var index = 0;
        foreach(var str in strs)
        {
            var chars = str.ToArray();
            Array.Sort(chars);
            var key = new string(chars);

            if(indexes.ContainsKey(key))
            {
                output[indexes[key]].Add(str);
            }
            else
            {
                indexes.Add(key, index++);
                output.Add(new List<string> {str});
            }
        }

        return output;
    }
}