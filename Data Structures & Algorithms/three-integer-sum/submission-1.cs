public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new();        
        // Sort the numbers: [-4,-1,-1,0,1,2]        
        Array.Sort(nums);
        // Run for loop on sorted input, add see what two numbers add up to and if there is negative of that.    
        for (int i = 0; i < nums.Length; i++) {
            int currNum = nums[i];
            if(i > 0 && currNum == nums[i - 1])
                continue;
            // Loop through the array and see if there are two numbers that sum up to negative currNum
            // For example if currNum = 2, are there two numbers that add up to -2
            int start = i+1, end = nums.Length -1;
            while(start < end)
            {
                if(start != i ) {
                    int target = -currNum;
                    int sum = nums[start] + nums[end];
                    if(sum < target) {
                        start++;
                    }
                    else if (sum > target) {
                        end --;
                    }
                    else // We have found 3 numbers that match
                    {
                        Console.WriteLine($"Found triplet: {currNum}, {nums[start]}, {nums[end]}");
                        List<int> currTriplets = [currNum, nums[start], nums[end]];
                        result.Add(currTriplets);
                        start++;
                        end --;

                        while (start < end && nums[start] == nums[start - 1])
                            start++;

                        while (start < end && nums[end] == nums[end + 1])
                            end--;
                    }
                }  
                else {
                    start++;
                }             
            }
        }

        return result;
    }
}
