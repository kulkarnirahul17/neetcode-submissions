public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        // First calculate the left prefix product
        int[] leftProduct = new int[nums.Length];
        int product = 1;
        for (int i = 0; i < nums.Length; i ++) {            
            if(i == 0) leftProduct[i] = 1;
            else {               
                product = product * nums[i -1];
                leftProduct[i] = product;
            } 
        }
       
        // Then calculate the right product
        int[] rightProduct = new int[nums.Length];
        
        product = 1;
        for (int i = nums.Length -1; i >= 0; i--) {            
            if(i == nums.Length -1) rightProduct[i] = 1;
            else {
                product = product * nums[i + 1];
                rightProduct[i] = product;
            } 
        }

        // Product of leftProduct and RightProduct will give you final result
        for (int i = 0; i < nums.Length; i++) {
            result[i] = leftProduct[i] * rightProduct[i];
        }

        return result;
    }
}
