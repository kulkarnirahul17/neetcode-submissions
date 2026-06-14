public class Solution {   
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new();
        int n = nums.Length;

        //First create a dictionary or frequency map of elements in the array
        foreach(int num in nums) {
            if (freq.TryGetValue(num, out int currentCount))
            {
                // Key exists: Increment the retrieved value
                freq[num] = currentCount + 1;
            }
            else
            {
                // Key missing: Add it with an initial value of 1
                freq[num] = 1;
            }
        }

        // Create an list of size n + 1, at the nth index, we store the list of values
        List<int>[] al = new List<int>[n + 1];
        foreach(var kv in freq) {
            int key = kv.Key;
            int value = kv.Value;

            // Check if the value at index already has a list? If not create a new list
            if(al[value] == null) {
                al[value] = new List<int>();
            }
            al[value].Add(key);
        }
        
        //Now loop list from backward index and return the top k elements
        var result = new int[k];
        int k_ind = 0;
        for(int i=al.Length - 1; i>=0; i--) {
            if(al[i] != null) {
                foreach(int val in al[i]) {
                    result[k_ind ++] = val;
                    if(k_ind == k) {
                        return result;
                    }
                }                
            }
        }
        return result;
    }
}