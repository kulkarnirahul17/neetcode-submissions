public class Solution {
    public List<List<int>> Combine(int n, int k) {
        List<List<int>> result = new();
        List<int> currSet = new();
        //Start with 1, up to n
        CombineHelper(1, n, k, result, currSet);
        return result;
    }

    public void CombineHelper(int start, int n, int k, List<List<int>> result, List<int> currSet)
    {
        if(currSet.Count == k)
        {
            result.Add([..currSet]);
            return;
        }
        for(int i = start; i <= n; i++) {
            currSet.Add(i);
            CombineHelper(i + 1, n, k, result, currSet);
            currSet.RemoveAt(currSet.Count - 1);
        }
    }
}