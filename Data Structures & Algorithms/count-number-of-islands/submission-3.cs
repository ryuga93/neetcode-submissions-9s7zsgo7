public class Solution {
    public int NumIslands(char[][] grid) {
        var count = 0;
        for (var r = 0; r < grid.Length; r++)
        {
            for (var c = 0; c < grid[0].Length; c++)
            {
                if (grid[r][c] == '1')
                {
                    Dfs(r, c, grid);
                    count++;
                }
            }
        }

        return count;
    }

    private void Dfs(int row, int col, char[][] grid)
    {
        if (row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length || grid[row][col] == '0')
        {
            return;
        }

        grid[row][col] = '0';

        Dfs(row - 1, col, grid);
        Dfs(row, col - 1, grid);
        Dfs(row + 1, col, grid);
        Dfs(row, col + 1, grid);
    }
}
