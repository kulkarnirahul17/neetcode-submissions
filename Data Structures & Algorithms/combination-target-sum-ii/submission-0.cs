public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> result = new();
        List<int> currSet = new();
        Array.Sort(candidates);
        Helper(candidates, 0, 0, target, result, currSet);

        return result;
    }

    private void Helper(int[] candidates, int start, int sum, int target, List<List<int>> result, List<int> currSet)
    {
        if(sum == target)
        {
            result.Add([..currSet]);
            return;
        }
        if(start >= candidates.Length || sum > target)
            return;

        for(int i = start; i < candidates.Length; i++)
        {
            if(i > start && candidates[i] == candidates[i -1])
                continue;

            sum += candidates[i];  
            if(sum > target)
                break;
            currSet.Add(candidates[i]);
            Helper(candidates, i + 1, sum, target, result, currSet);
            sum -= candidates[i];
            currSet.RemoveAt(currSet.Count - 1);
        }
        
    }
}
