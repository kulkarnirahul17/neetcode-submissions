public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>(Comparer<int>.Create((x,y)=> y.CompareTo(x)));
        for(int i = 0 ; i < stones.Length; i++)
        {
            heap.Enqueue(stones[i], stones[i]);
        }

        while(heap.Count >= 2) 
        {
            int first = heap.Dequeue();
            int second = heap.Dequeue();
            if(first != second) {
                int diff = Math.Abs(first - second);
                heap.Enqueue(diff, diff);
            }
        }

        return heap.Count > 0 ? heap.Dequeue() : 0;
    }
}
