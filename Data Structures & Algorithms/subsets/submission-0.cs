public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new();
        List<int> currSet = new();
        Helper(nums, 0, result, currSet);
        return result;
    }

    private void Helper(int[] nums, int i, List<List<int>> result, List<int> currSet)
    {
        if(i >= nums.Length)
        {
            result.Add([..currSet]);
            return;
        }
        // Generate set with the current 
        currSet.Add(nums[i]);
        Helper(nums, i + 1, result, currSet);

        // Generate set without current num added
        currSet.RemoveAt(currSet.Count -1);
        Helper(nums, i + 1, result, currSet);
    }
}
