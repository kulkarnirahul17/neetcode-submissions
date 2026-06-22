public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        /*
            when open == closed == n// valid combination found; add to result;
            only add open when open < n
            only add closed closed < open
        */
        List<string> result = [];
        List<char> currSet = [];

        Backtrack(0,0);
        return result;
        
        void Backtrack(int open, int closed)
        {
            if(open == closed && open == n)
            {
                result.Add(new string(currSet.ToArray()));
                return;
            }
            if(open < n) // You can add an open bracket
            {
                currSet.Add('(');
                Backtrack(open + 1, closed);
                currSet.RemoveAt(currSet.Count - 1);
            }
            if(closed < open) 
            {
                currSet.Add(')');
                Backtrack(open, closed + 1);
                currSet.RemoveAt(currSet.Count - 1);
            }               
        }       
    }
}