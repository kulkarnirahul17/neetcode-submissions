public class Solution {

    // Encodes a list of strings to a single string.
    public string Encode(IList<string> strs) {
        // You can choose to encode the actual strings
        char delimiter = '#';
        //["test", "#1tch]
        // 4#test5##1tch
        StringBuilder sb = new();
        foreach(var str in strs) 
        {
            sb.Append($"{str.Length}{delimiter}{str}");
        }
        return sb.ToString();
    }

    // Decodes a single string to a list of strings.
    public List<string> Decode(string s) {
        char delimiter = '#';
        List<string> result = new();

        // 4#test5##1tch
        int i = 0;
        while(i < s.Length) {
            // Use j pointer to get the number of characters, 
            // For example 123t#erer..... Means that there are 123 characters in first word.
            int j=i;
            StringBuilder countSb = new();
            while(j < s.Length & s[j] != delimiter) {
                countSb.Append(s[j++]);
            }
            int.TryParse(countSb.ToString(), out int noOfChars);            
            // At this point j is at delimiter.
            // So, let's grab the substring starting from j + 1 of length noOfChars
            string word = s.Substring(j+1, noOfChars);
            result.Add(word);
            i = j + noOfChars + 1;
        }                           
        return result;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(strs));