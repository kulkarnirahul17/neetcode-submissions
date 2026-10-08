public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> countS = [];
        Dictionary<char, int> countT = [];

        for(int i=0; i < s.Length; i++)
        {
            countS.TryGetValue(s[i], out int cSValue);
            countS[s[i]] = cSValue + 1;

            countT.TryGetValue(t[i], out int cTValue);
            countT[t[i]] = cTValue + 1;
        }

        foreach(var kv in countS)
        {
            countT.TryGetValue(kv.Key, out int cTValue);
            if(countS[kv.Key] != cTValue)
            {               
                return false;
            }
                
        }

        return true;
    }
}
