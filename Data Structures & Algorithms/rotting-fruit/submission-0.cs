public class Solution {
    public int OrangesRotting(int[][] grid) {
        int time = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;
        bool[,] visited = new bool[rows, cols];
        Queue<(int, int)> queue = new();

        // First get the oranges that are rotting at minute 0 and add them to the queue;

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(grid[i][j] == 2)
                {
                    queue.Enqueue((i,j));
                    visited[i, j] = true;
                }
            }            
        }
        
        int[][] neighbors = new int[][]
        {
            new int[] {1, 0}, new int[] {-1, 0}, new int[] {0, 1}, new int[] {0, -1}
        };
        while(queue.Count > 0)
        {
            int size = queue.Count;
            bool rottenAny = false;
            for(int i = 0; i < size; i++)
            {
                var (r, c) = queue.Dequeue();
                // Mark neighbors as rotten
                foreach(var neighbor in neighbors)
                {
                    int newR = r + neighbor[0];
                    int newC = c + neighbor[1];

                    if(Math.Min(newR, newC) < 0 || newR == rows || newC == cols || visited[newR, newC]
                     || grid[newR][newC] != 1) // Not a fresh fruit to rot
                        continue;
                    
                    grid[newR][newC] = 2;
                    visited[newR, newC] = true;
                    queue.Enqueue((newR, newC));
                    rottenAny = true;
                }                

            }
            if(rottenAny)
                time ++;
        }

        // If there is still any fresh fruit, then return -1;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(grid[i][j] == 1)
                {
                    return -1;
                }
            }            
        }
        
        return time ;
    }
}
