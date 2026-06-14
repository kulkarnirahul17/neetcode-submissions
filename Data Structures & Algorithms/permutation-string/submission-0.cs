public class Solution {
    public bool CheckInclusion(string s1, string s2) {     
        Dictionary<char,int> s1Map = new();
        Dictionary<char,int> s2Map = new();

        int charactersMatched = 0;

        int start = 0, end = 0;
        char currChar = default;

        for(int i = 0; i < s1.Length; i++) {
            if(!s1Map.ContainsKey(s1[i])) {
                s1Map.Add(s1[i], 0);
            }
            s1Map[s1[i]] ++;
        }

        while(end < s2.Length) {
            currChar = s2[end];
            // If there is no match, 
            if(!s1Map.ContainsKey(currChar)) 
            {
                s2Map.Clear();               
                charactersMatched = 0;
                start = end + 1;
            }
            else 
            {
                // Characters in string match
                if(!s2Map.ContainsKey(currChar)) {
                    s2Map.Add(currChar, 0);
                }            
                s2Map[currChar] ++;
                if(s2Map[currChar] == s1Map[currChar]) {
                    charactersMatched ++;
                }
                if(charactersMatched == s1Map.Count) {
                    return true;
                }                
                while(s2Map[currChar] > s1Map[currChar]) {
                    char startChar = s2[start];
                    if (s2Map.ContainsKey(startChar)) {
                        // If we're about to lose a matched character, adjust count
                        if (s2Map[startChar] == s1Map[startChar]) {
                            charactersMatched--;
                        }
                        s2Map[startChar]--;
                    }           
                    start ++;
                }                            
            }
                        
            end++;
        }

        return false;
    }
}
