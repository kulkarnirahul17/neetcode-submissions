public class Solution {
    public bool IsPalindrome(string s) {
        int start = 0, end = s.Length -1;
        // camt ac
        while(start < end) {
            if(!Char.IsLetterOrDigit(s[start])) 
            {
                start ++;
            }
            else if (!Char.IsLetterOrDigit(s[end])) 
            {
                end --;
            }
            else if(Char.ToLowerInvariant(s[start++]) != Char.ToLowerInvariant(s[end--])) 
            {
                return false;
            }            
        }
        return true;
    }
}
