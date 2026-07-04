public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        /*
        -1, water, no traverse
        0, treasure chest
        int.MaxValue = Land, traversible.
        */
        int rows = grid.Length;
        int cols = grid[0].Length;
        bool[,] visited = new bool[rows, cols];
        Queue<(int, int)> q = new();
        int[][] neighbors = [[1,0], [-1,0], [0,1], [0,-1]];
        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                // treasures available. Add to Queue and perform bfs
                if(grid[r][c] == 0)
                {
                    q.Enqueue((r,c));
                    visited[r,c] = true;
                }
            }
        }
        if(q.Count == 0)
            return;
        int level = 0;

        while(q.Count > 0)
        {
            int size = q.Count;
            for(int i = 0; i < size; i++)
            {
                var (r,c) = q.Dequeue();                               

                foreach(var neighbor in neighbors)
                {
                    int rr = r + neighbor[0];
                    int cc = c + neighbor[1];

                    if(Math.Min(rr, cc) < 0 || rr == rows || cc == cols || visited[rr,cc] || grid[rr][cc] == -1)
                        continue;

                    visited[rr,cc] = true;
                    q.Enqueue((rr,cc));
                }

                if(level !=0) 
                {
                    grid[r][c] = level;
                } 
            }            
            level ++;
        }
    }
}