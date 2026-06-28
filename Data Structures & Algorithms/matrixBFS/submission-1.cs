public class Solution {
    public int ShortestPath(int[][] grid) {
        int length = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;

        bool[,] visited = new bool[rows, cols];
        
        Queue<(int, int)> qu = new();
        qu.Enqueue((0,0));
        visited[0, 0] = true;
        
        while(qu.Count > 0)
        {          
            int size = qu.Count;
            for(int i = 0; i < size; i++)
            {

                var (r, c) = qu.Dequeue();

                if(r == rows - 1 && c == cols - 1)
                {
                    return length;
                }

                int[][] neighbors = 
                {
                    new int[]{0,1}, new int[]{0,-1}, new int[]{1,0}, new int[]{-1,0}
                };

                foreach (var neighbor in neighbors)
                { 
                    int newR = r + neighbor[0];
                    int newC = c + neighbor[1];

                    if(newR < 0 || newC < 0 || newR == rows || newC == cols || grid[newR][newC] == 1 || visited[newR, newC])
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
