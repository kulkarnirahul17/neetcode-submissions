public class Solution {
    public int NumIslands(char[][] grid) {

        int result = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;
        bool[,] visited = new bool[rows,cols];

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(grid[i][j] == '1' && !visited[i, j])
                {
                    dfs(i, j);
                    result ++;
                }
            }
        }
        return result;

        bool dfs(int r, int c)
        {
            if(r < 0 || r >= rows || c < 0 || c >= cols || visited[r, c] || grid[r][c] == '0')
            {
                return false;
            }
            visited[r,c] = true;
            dfs (r - 1, c);
            dfs (r + 1, c);
            dfs (r, c - 1);
            dfs (r, c + 1);            
            return true; 
        }
    }
}