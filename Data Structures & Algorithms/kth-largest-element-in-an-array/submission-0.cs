public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> pq = new();
        for(int i = 0; i < nums.Length; i++)
        {
            pq.Enqueue(nums[i], nums[i]);
            if(pq.Count > k) {
                pq.Dequeue();
            }
        }
        return pq.Peek();
    }
}
