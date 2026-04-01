public class TrieNode()
{
    public TrieNode[] children = new TrieNode[26];
    public bool isEndWord = false;
}

public class WordDictionary {
    private TrieNode root;
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        var current = root;
        foreach (var c in word)
        {
            if (c == '.')
            {
                continue;
            }
            
            var i = c - 'a';
            if (current.children[i] == null)
            {
                current.children[i] = new TrieNode();
            }

            current = current.children[i];
        }

        current.isEndWord = true;
    }
    
    public bool Search(string word) {
        return Dfs(word, 0 , root);
        
    }

    private bool Dfs(string word, int remainingIndex, TrieNode root)
    {
        var current = root;

        for (var i = remainingIndex; i < word.Length; i++)
        {
            var c = word[i];

            if (c == '.')
            {
                foreach(var childNode in current.children)
                {
                    if (childNode != null && Dfs(word, i + 1, childNode))
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                var index = c - 'a';
                if (current.children[index] == null)
                {
                    return false;
                }

                current = current.children[index];
            }
        }

        return current.isEndWord;
    }
}
