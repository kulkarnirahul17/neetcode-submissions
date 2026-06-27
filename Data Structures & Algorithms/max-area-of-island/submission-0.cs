public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        bool[,] visited = new bool[rows, cols];
        int max = 0;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(grid[i][j] == 1 && !visited[i,j])
                {
                    max = Math.Max(max, dfs(i, j));
                }
            }
        }
         
        return max;

        int dfs(int r, int c) 
        {
            if(r < 0 || r >= rows || c < 0 || c >= cols || visited[r, c] || grid[r][c] == 0)
            {
                return 0;
            }
            visited[r, c] = true;
            return 1 + dfs(r - 1, c) + dfs(r + 1, c) + dfs (r, c - 1) + dfs(r, c + 1);
        }
    }
}
