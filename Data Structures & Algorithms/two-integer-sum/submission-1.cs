public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> set = new();
        int[] result = new int[2];
        for(int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            var diff = target - num;
            if(set.ContainsKey(diff)) {
                int diffIndex = set[diff];
                result[0] = diffIndex > i? i: diffIndex;
                result[1] = diffIndex > i? diffIndex: i;
                return result;
            }
            set.Add(num, i);
        }

        return result;
    }
}
