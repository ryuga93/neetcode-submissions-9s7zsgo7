public class Solution {
    private int rowLength = 0;
    private int colLength = 0;

    private HashSet<(int, int)> visited = new HashSet<(int, int)>();

    public bool Exist(char[][] board, string word)
    {
        rowLength = board.Length;
        colLength = board[0].Length;

        for (var r = 0; r < rowLength; r++)
        {
            for (var c = 0; c < colLength; c++)
            {
                if (HaveChar(r, c, 0, board, word))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool HaveChar(int row, int col, int k, char[][] board, string word)
    {
        if (visited.Contains((row, col)))
        {
            return false;
        }
        
        if (row < 0 || row >= rowLength)
        {
            return false;
        }

        if (col < 0 || col >= colLength)
        {
            return false;
        }

        if (board[row][col] != word[k])
        {
            return false;
        }

        if (k == word.Length - 1)
        {
            return true;
        }

        visited.Add((row, col));
        
        var result = HaveChar(row - 1, col, k + 1, board, word) ||
                     HaveChar(row, col - 1, k + 1, board, word) ||
                     HaveChar(row + 1, col, k + 1, board, word) ||
                     HaveChar(row, col + 1, k + 1, board, word);
        
        visited.Remove((row, col));

        return result;
    }
}
