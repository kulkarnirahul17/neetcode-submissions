public class Solution {
    public int LongestConsecutive(int[] nums) {
        // [2,20,4,11,10,3,4,5]
        // Add nums to map
               
        
        HashSet<int> map = new();
        for(int i = 0; i < nums.Length; i++) {
            if(!map.Contains(nums[i])) {
                map.Add(nums[i]);
            }            
        }
        int max_len = 0;
        // Loop through array
        for(int i = 0; i < nums.Length; i ++) {
            int num = nums[i];
            // For each element, see if it beginning of sequence, meaning num - 1 does not exist in map             
            if(map.Contains(num -1)) {
                // if it does exist, then skip and move onto next number.
               continue; 
            }
            else {
                // otherwise run while loop until consequent numbers exist, get that length, update max
                int curr_len = 1;
                while(map.Contains(num + 1)) {
                    curr_len ++;
                    num ++;
                }
                max_len = Math.Max(curr_len, max_len);
            }
        
        }
        return max_len;
    }
}
