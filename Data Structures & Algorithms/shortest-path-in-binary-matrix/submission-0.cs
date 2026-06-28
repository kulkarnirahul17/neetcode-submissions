public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        if(grid[0][0] == 1)
        {
            return -1;
        }

        int rows = grid.Length;
        int cols = grid[0].Length;
        bool[,] visited = new bool[rows, cols];
        Queue<(int, int)> qu = new();
        
        qu.Enqueue((0,0));
        visited[0,0] = true;
        int length = 1;
        int[][] neighbors = new int[][]
        {
            new int[] { 0, 1}, // right
            new int[] { 0, -1}, // left
            new int[] {-1, 0}, // top
            new int[] {1, 0}, // bottom            
            new int[] {-1, -1}, // diag up left
            new int[] {-1, 1}, // diag up right
            new int[] {1, -1}, // diag down left
            new int[] {1,1}, // diag down right
        };

        while(qu.Count > 0)
        {
            int size = qu.Count;
            for(int i = 0; i < size; i++)
            {
                var (r, c) = qu.Dequeue();
                if(r == rows - 1 && c == cols - 1)
                    return length;
                
                foreach(var neighbor in neighbors)
                {
                    int newR = r + neighbor[0];
                    int newC = c + neighbor[1];

                    if(Math.Min(newR, newC) < 0 || newR == rows || newC == cols || 
                        visited[newR, newC] || grid[newR][newC] == 1)
                        continue;
                    
                    qu.Enqueue((newR, newC));
                    visited[newR, newC] = true;
                }
            }
            length++;
        }
        return -1;
    }
}