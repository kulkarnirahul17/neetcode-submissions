public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new();
        List<int> currSet = new();
        bool[] used = new bool[nums.Length];
        Helper(nums, used, result, currSet);
        return result;
    }

    public void Helper(int[] nums, bool[] used, List<List<int>> result, List<int> currSet)
    {
        if(currSet.Count == nums.Length)
        {
            result.Add([..currSet]);
            return;
        }
        for(int i=0; i < nums.Length; i ++)
        {       
            if(used[i]) continue;     
            used[i] = true;
            currSet.Add(nums[i]); 
            Helper(nums, used, result, currSet);
            currSet.RemoveAt(currSet.Count - 1);
            used[i] = false;
        }        
    }
}
