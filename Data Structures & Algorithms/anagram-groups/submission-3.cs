public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> result = new();
        Dictionary<string, List<string>> anagramGroups = new();
        foreach(string s in strs) {
            //Create a freq map of 26 characters
            int[] freq = new int[26];
            foreach(char c in s) {
                freq[c -'a'] ++;
            }
            StringBuilder sb = new();
            for(int i = 0; i < 26; i++) {
                if(freq[i] > 0) {
                    sb.Append($"{(char)(97 + i)}{freq[i]}");
                }            
            }
            string key = sb.ToString();            
            if(anagramGroups.ContainsKey(key)) {
                anagramGroups[key].Add(s);
            }
            else {
                List<string> ls = new();
                ls.Add(s);
                anagramGroups.Add(key, ls);
            }
        }

        foreach(var item in anagramGroups) {
            result.Add(item.Value);
        }
        return result;
    }
}
