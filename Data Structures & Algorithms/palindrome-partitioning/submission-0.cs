public class Solution {
    public List<List<string>> Partition(string s) {
        List<List<string>> result = new();
        List<string> part = new();
        dfs(0);
        return result;

        void dfs(int i)
        {
            if(i >= s.Length)
            {
                result.Add(new List<string>(part));
                return;
            }
            for(int j = i; j < s.Length; j++)
            {
                if(isPalindrome(s, i, j)) 
                {
                    part.Add(s.Substring(i, j - i + 1));
                    dfs(j + 1);
                    part.RemoveAt(part.Count - 1);
                }
            }
        }
    }

    private bool isPalindrome(string s, int i, int j)
    {       
        while (i < j)
        {
            if (s[i++] != s[j--])
                return false;
        }
        return true;
    }    
}
