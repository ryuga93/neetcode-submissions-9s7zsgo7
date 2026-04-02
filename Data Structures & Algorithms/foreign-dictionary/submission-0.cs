public class Solution
{
    private Dictionary<char, HashSet<char>> adjacent = new Dictionary<char, HashSet<char>>();
    private Dictionary<char, bool> visited = new Dictionary<char, bool>();
    private List<char> result = new List<char>();

    public string foreignDictionary(string[] words) {
        foreach (var word in words)
        {
            foreach (var character in word)
            {
                adjacent[character] = new HashSet<char>();
            }
        }

        for (var i = 0; i < words.Length - 1; i++)
        {
            var words1 = words[i];
            var words2 = words[i + 1];
            var minLength = Math.Min(words1.Length, words2.Length);
            if (words1.Length > words2.Length && words1.Substring(0, minLength) == words2.Substring(0, minLength))
            {
                return "";
            }

            for (var j = 0; j < minLength; j++)
            {
                if (words1[j] != words2[j])
                {
                    adjacent[words1[j]].Add(words2[j]);
                    break;
                }
            }
        }

        foreach (var c in adjacent.Keys)
        {
            if (TopologicalDfs(c))
            {
                return "";
            }
        }
        
        result.Reverse();

        string sb = "";
        foreach (var c in result)
        {
            sb += c;
        }

        return sb;
    }

    private bool TopologicalDfs(char c)
    {
        if (visited.ContainsKey(c))
        {
            return visited[c];
        }

        visited[c] = true;

        foreach (var next in adjacent[c])
        {
            if (TopologicalDfs(next))
            {
                return true;
            }
        }

        visited[c] = false;

        result.Add(c);

        return false;
    }
}