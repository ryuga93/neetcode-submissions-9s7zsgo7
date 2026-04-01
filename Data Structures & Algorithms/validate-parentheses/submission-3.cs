public class Solution {
    public bool IsValid(string s)
    {

        var dict = new Dictionary<char, char>() { { ')', '(' }, { '}', '{' }, { ']', '[' } };
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (dict.ContainsKey(c))
            {
                if (stack.Count != 0 && stack.Peek() == dict[c])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}
