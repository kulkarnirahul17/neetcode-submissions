public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        int rowL = image.Length;
        int colL = image[0].Length;
        bool[,] visited = new bool[rowL, colL];
        int originalColor = image[sr][sc];
        dfs(sr, sc);
        return image;

        void dfs(int r, int c) 
        {            
            if(r < 0 || r >= rowL || c < 0 || c >= colL || 
                    image[r][c] != originalColor || visited[r,c])
            {
                return;
            }
            
            image[r][c] = color;
            visited[r,c] = true;
            
            dfs(r - 1, c);
            dfs(r + 1, c);
            dfs(r, c + 1);
            dfs(r, c - 1);
            
        }
    }
}