public class Solution {
    public int[][] KClosest(int[][] points, int k) {       
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
