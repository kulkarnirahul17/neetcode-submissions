public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<List<int>> result = new();
        List<int> currSet = new();
        Array.Sort(nums);
        Helper(nums, 0, result, currSet);
        return result;
    }

    public void Helper(int[] nums, int i, List<List<int>> result, List<int> currSet)
    {
        if(i >= nums.Length)
        {
            result.Add([..currSet]);
            return;
        }
        // Add curr to currSet and recursively call for next number
        currSet.Add(nums[i]);
        Helper(nums, i+1, result, currSet);

        // Remove curr num from curr set and generate
        currSet.RemoveAt(currSet.Count -1);
        while(i + 1 < nums.Length && nums[i] == nums[i + 1])
        {
            i = i + 1;
        }
        Helper(nums, i + 1, result, currSet);
    }
}
