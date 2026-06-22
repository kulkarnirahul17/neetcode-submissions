public class Solution {
    public List<List<int>> PermuteUnique(int[] nums) {        
        List<List<int>> result = new();
        List<int> currSet = new();
        Array.Sort(nums);
        bool[] seen = new bool[nums.Length];
        PermuteWithDuplicates(nums, result, currSet, seen);
        return result;
    }

    public void PermuteWithDuplicates(int[] nums, List<List<int>> result, List<int> currSet, bool[] seen)
    {
        if(currSet.Count == nums.Length)
        {
            result.Add(new List<int>(currSet));
            return;
        }
        for(int i = 0; i < nums.Length; i++)
        {
            if(seen[i]) continue;

            if(i > 0 && nums[i] == nums[i-1] && !seen[i-1]) continue;
            
            currSet.Add(nums[i]);
            seen[i] = true;
            PermuteWithDuplicates(nums, result, currSet, seen);
            currSet.RemoveAt(currSet.Count -1);
            seen[i] = false;
            
        }
    }
}