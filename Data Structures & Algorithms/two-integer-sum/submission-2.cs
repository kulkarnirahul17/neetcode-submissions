public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();
        int[] result = new int[2];
        for(int i=0; i < nums.Length; i++) {
            int num = nums[i];
            if(!dict.ContainsKey(num)) {
                dict.Add(num, i);
            }
        }

        for(int i=0; i < nums.Length; i++) {            
            if(dict.ContainsKey(target - nums[i])) {
                int tp = dict[target-nums[i]];
                result[0] = tp < i ? tp : i;
                result[1] = tp > i ? tp : i;
            }
        }

        return result;
    }
}
