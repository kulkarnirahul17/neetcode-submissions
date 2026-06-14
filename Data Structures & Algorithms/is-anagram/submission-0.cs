public class Solution {
    public bool IsAnagram(string s, string t) {
        // Using dictionary

        if(s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> charFreq  = new();

        foreach(char c in s) {
            if(!charFreq.ContainsKey(c))
                charFreq.Add(c, 1);
            else
                charFreq[c] ++;
        }

        foreach(char c in t) {
            if(!charFreq.ContainsKey(c))
                return false;
            charFreq[c] --;
            if(charFreq[c] < 0) {
                return false;
            }
        }

        return true;
    }
}