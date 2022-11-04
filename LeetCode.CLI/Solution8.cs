//https://leetcode.com/problems/valid-parentheses/
public class Solution8 {
    public bool IsValid(string s)
    {
        var st = new Stack<char>();
        for (var i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '[':
                    st.Push(s[i]);
                    break;
                case '{':
                    st.Push(s[i]);
                    break;
                case '(':
                    st.Push(s[i]);
                    break;
                case ']':
                    if (st.Count == 0 || st.Peek() != '[') return false;
                    st.Pop();
                    break;
                case '}':
                    if (st.Count == 0 || st.Peek() != '{') return false;
                    st.Pop();
                    break;
                case ')':
                    if (st.Count == 0 || st.Peek() != '(') return false;
                    st.Pop();
                    break;
            }
        }
        return st.Count==0;
    }
}