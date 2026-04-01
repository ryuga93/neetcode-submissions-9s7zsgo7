public class Solution {
    private int[][] directions = new int[][]
        {
            new int[] { -1, 0 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { 0, 1 }
        };

        public List<List<int>> PacificAtlantic(int[][] heights)
        {
            var ROWS = heights.Length;
            var COLS = heights[0].Length;
            bool[,] pacific = new bool[ROWS, COLS];
            bool[,] atlantic = new bool[ROWS, COLS];

            for (var r = 0; r < ROWS; r++)
            {
                Dfs(r, 0, heights, pacific);
                Dfs(r, COLS - 1, heights, atlantic);
            }

            for (var c = 0; c < COLS; c++)
            {
                Dfs(0, c, heights, pacific);
                Dfs(ROWS - 1, c, heights, atlantic);
            }

            var result = new List<List<int>>();

            for (var i = 0; i < ROWS; i++)
            {
                for (var j = 0; j < COLS; j++)
                {
                    if (pacific[i, j] && atlantic[i, j])
                    {
                        result.Add(new List<int>() { i, j });
                    }
                }
            }

            return result;
        }

        private void Dfs(int row, int col, int[][] heights, bool[,] visited)
        {
            visited[row, col] = true;

            foreach (var direction in directions)
            {
                var newRow = row + direction[0];
                var newCol = col + direction[1];

                if (newRow >= 0 && newCol >= 0 && newRow < heights.Length && newCol < heights[0].Length &&
                    !visited[newRow, newCol] && heights[newRow][newCol] >= heights[row][col])
                {
                    Dfs(newRow, newCol, heights, visited);
                }
            }
        }
}
