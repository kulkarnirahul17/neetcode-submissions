public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        
        // First calculate the prefix product, at each index, total product of elements to the left
        int[] leftProduct = new int[nums.Length];
        // nums = [2,4,8,6]
        // left = [1,2, ]
        int product = 1;
        for(int i = 0; i <nums.Length; i++) {            
            if (i == 0) {
                leftProduct[i] = 1;
            }
            else {
                product = nums[i-1] * product;
                leftProduct[i] = product;
            }
        }

        // Now calculate product of all elements to the right at particular right; postfix product.
        int[] rightProduct = new int[nums.Length];
        product = 1;
        for(int i = nums.Length - 1; i >=0; i--) {            
            if (i == nums.Length - 1) {
                rightProduct[i] = 1;
            }
            else {
                product = product * nums[i+1];
                rightProduct[i] = product;
            }
        }

        // Now calculate the result.
        for (int i = 0; i < nums.Length; i++) {
            result[i] = leftProduct[i] * rightProduct[i];
        }
        return result;
    }
}
