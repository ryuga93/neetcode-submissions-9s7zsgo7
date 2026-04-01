public class TrieNode
{
    public TrieNode[] children = new TrieNode[26];
    public int wordIndex = -1;
    public int appearCount = 0;

    public void AddWord(string word, int index)
    {
        var current = this;
        current.appearCount++;

        foreach (var c in word)
        {
            var i = c - 'a';
            current.children[i] ??= new TrieNode();

            current = current.children[i];
            current.appearCount++;
        }

        current.wordIndex = index;
    }
}

public class Solution {
    private List<string> result = new List<string>();

    public List<string> FindWords(char[][] board, string[] words)
    {
        var root = new TrieNode();
        for (var i = 0; i < words.Length; i++)
        {
            root.AddWord(words[i], i);
        }

        for (var r = 0; r < board.Length; r++)
        {
            for (var c = 0; c < board[0].Length; c++)
            {
                Dfs(r, c, board, words, root);
            }
        }

        return result;
    }

    private void Dfs(int row, int col, char[][] board, string[] words, TrieNode node)
    {
        if (row < 0 || col < 0 || row >= board.Length || col >= board[0].Length || board[row][col] == '#' ||
            node.children[board[row][col] - 'a'] == null)
        {
            return;
        }

        var temp = board[row][col];
        board[row][col] = '#';

        var childNodeIndex = temp - 'a';
        var childNode = node.children[childNodeIndex];

        if (childNode.wordIndex != -1)
        {
            result.Add(words[childNode.wordIndex]);
            childNode.wordIndex = -1;
            childNode.appearCount--;
            if (childNode.appearCount == 0)
            {
                childNode = null;
                node.children[childNodeIndex] = null;
                board[row][col] = temp;
                return;
            }
        }

        Dfs(row - 1, col, board, words, childNode);
        Dfs(row, col - 1, board, words, childNode);
        Dfs(row + 1, col, board, words, childNode);
        Dfs(row, col + 1, board, words, childNode);

        board[row][col] = temp;
    }
}