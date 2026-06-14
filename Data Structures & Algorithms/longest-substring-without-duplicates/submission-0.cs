public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // string s = "zxypbyxyxz"
        // left = 0, right = 0
        int left = 0, right = 0;
        int maxLen = 0;
        // Hashset = [z,x,y,p,b] , currlen = 5, maxLen = 5
        HashSet<char> hash = new();
        for (; right < s.Length; right++) {
            if(!hash.Contains(s[right])) {               
                maxLen = Math.Max(right -left + 1, maxLen);                
            }
            else {                
                while(left < right && hash.Contains(s[right])) {
                    hash.Remove(s[left]);
                    left ++;
                }
            }
            hash.Add(s[right]);
        }
        return maxLen;
        
    }
}
