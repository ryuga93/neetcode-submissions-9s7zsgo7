public class TrieNode
{
    public TrieNode[] children = new TrieNode[26];
    public bool isEndOfWord = false;
}

public class PrefixTree 
{
    private TrieNode root;

    public PrefixTree() 
    {
        root = new TrieNode();
    }
    
    public void Insert(string word) 
    {
        TrieNode current = root;
        foreach (var c in word)
        {
            var nodeIndex = c - 'a';
            if (current.children[nodeIndex] == null)
            {
                current.children[nodeIndex] = new TrieNode();
            }

            current = current.children[nodeIndex];
        }

        current.isEndOfWord = true;
    }
    
    public bool Search(string word) 
    {
        var current = root;
        foreach (var c in word)
        {
            var nodeIndex = c - 'a';
            if (current.children[nodeIndex] == null)
            {
                return false;
            }

            current = current.children[nodeIndex];
        }

        return current.isEndOfWord;
    }
    
    public bool StartsWith(string prefix) 
    {
        var current = root;

        foreach (var c in prefix)
        {
            var nodeIndex = c - 'a';
            if (current.children[nodeIndex] == null)
            {
                return false;
            }

            current = current.children[nodeIndex];
        }

        return true;
    }
}
