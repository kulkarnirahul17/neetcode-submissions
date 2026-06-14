public class Solution {

    // Encodes a list of strings to a single string.
    public string Encode(IList<string> strs) {
        // You can choose to encode the actual strings
        char delimiter = '#';
        // Choose a delimiter which indicates that while decoding the delimiter will split into array, say ; 
        StringBuilder sb = new();
        foreach(string s in strs) {           
            sb.Append($"{s.Length}{delimiter}{s}");            
        }      
        Console.WriteLine(sb.ToString());
        return sb.ToString();
    }

    // Decodes a single string to a list of strings.
    public List<string> Decode(string s) {
        List<string> result = new();
        char delimiter = '#';
        // Go through string character by character, create an end pointer for index.
        int i=0, j=0;
        StringBuilder sb = new();
        while(i < s.Length) { 
            Console.WriteLine(i); 
            j=i; //Pointer to get the number of integers
            StringBuilder noSb = new();
            while(s[j] != delimiter) {
                noSb.Append(s[j]);
                j++;
            }            
            int len = int.Parse(noSb.ToString());
            Console.WriteLine($"length of word: {len}; j+1: {j+1}");
            string word = s.Substring(j+1, len);
            Console.WriteLine($"word is: {word}");
            result.Add(word);
            i = j+ 1+len;
            Console.WriteLine($"i is at: {i}");
        }
                   
        return result;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(strs));