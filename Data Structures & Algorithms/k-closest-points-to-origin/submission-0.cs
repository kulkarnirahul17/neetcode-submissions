public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        // PriorityQueue
        /*
           [[0,2],[2,0],[2,2]]
           [0,2] -> d = 0^2 + 2^2 = 4, =sqrt(4) = 2
           [2,0] -> d = 2^2 + 0^2 = 4, sqrt(4) = 2
           [2,2] -> d = 2^2 + 2^2 = 8, sqrt(8) = 2.828
        */
        PriorityQueue<int[], double> pq = new();
        foreach(int[] point in points) 
        {
            double dist = GetEuclideanDistance(point[0], point[1]);            
            pq.Enqueue(point, dist);
        }
        int[][] result = new int[k][];        
        for(int i=0; i < k; i++)
        {
            int[] point = pq.Dequeue();
            result[i] = point;
        }
        return result;
    }

    private double GetEuclideanDistance(int x, int y) {
        int sum = x*x + y*y;        
        return Math.Sqrt(sum);
    }
}
