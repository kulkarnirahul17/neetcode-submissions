public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        int rowL = image.Length;
        int colL = image[0].Length;
        bool[,] visited = new bool[rowL, colL];
        int originalColor = image[sr][sc];
        return dfs(sr, sc, image);

        int[][] dfs(int r, int c, int[][] image) 
        {            
            if(r < 0 || r >= rowL || c < 0 || c >= colL || 
                    image[r][c] != originalColor || visited[r,c])
            {
                return image;
            }
            
            image[r][c] = color;
            visited[r,c] = true;
            
            var i1 = dfs(r - 1, c, image);
            var i2 = dfs(r + 1, c, i1);
            var i3 = dfs(r, c + 1, i2);
            var i4 = dfs(r, c - 1, i3);

            return i4;
        }
    }
}