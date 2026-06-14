public class Solution {
    public int FindDuplicate(int[] nums) {
        int dup = -1;
        for(int i = 0; i < nums.Length; i ++) 
        {
            int currNum = Math.Abs(nums[i]);

            if(nums[currNum] < 0) {
                dup = currNum;
                break;
            }
            nums[currNum] *= -1;
           
        }
        for(int i= 0; i < nums.Length; i++) {
            if(nums[i] < 0) {
                nums[i] *= -1;
            }
        }        
        return dup;
    }
}
