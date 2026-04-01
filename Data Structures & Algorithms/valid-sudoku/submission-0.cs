public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var squares = new Dictionary<string, HashSet<char>>();
        
        for (var r = 0; r < 9; r++)
        {
            for (var c = 0; c < 9; c++)
            {
                if (board[r][c] == '.')
                {
                    continue;
                }

                var val = board[r][c];
                var square = (r / 3) + "," + (c / 3); 
                if ((rows.ContainsKey(r) && rows[r].Contains(val)) || (cols.ContainsKey(c) && cols[c].Contains(val)) || (squares.ContainsKey(square) && squares[square].Contains(val)))
                {
                    return false;
                }

                if (!rows.ContainsKey(r))
                {
                    rows[r] = new HashSet<char>();
                }

                if (!cols.ContainsKey(c))
                {
                    cols[c] = new HashSet<char>();
                }
                
                if (!squares.ContainsKey(square))
                {
                    squares[square] = new HashSet<char>();
                }
                
                rows[r].Add(val);
                cols[c].Add(val);
                squares[square].Add(val);
            }
        }

        return true;
    }
}
