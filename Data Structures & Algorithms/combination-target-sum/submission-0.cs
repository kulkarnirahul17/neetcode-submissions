public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new();
        List<int> currSet = new();
        Array.Sort(nums);
        int sumSoFar = 0;
        Helper(nums, 0, sumSoFar, target, result, currSet);
        return result;
    }

    public void Helper(int[] nums, int start, int sumSoFar, int target, List<List<int>> result, List<int> currSet)
    {
        if(sumSoFar == target) {
            result.Add([..currSet]);
            return;
        } 
        else if(sumSoFar > target)
            return;       
        for(int i = start; i < nums.Length; i++) {           
            sumSoFar += nums[i];
            if(sumSoFar > target)
                break;
            currSet.Add(nums[i]);
            Helper(nums, i, sumSoFar, target, result, currSet);
            currSet.RemoveAt(currSet.Count -1);
            sumSoFar -= nums[i];
        }
    }
}