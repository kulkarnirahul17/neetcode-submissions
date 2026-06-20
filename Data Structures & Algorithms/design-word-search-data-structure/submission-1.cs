public class TrieNode 
{    
    public Dictionary<char, TrieNode> Children { get; set; } = new();
    public bool IsEndWord {get; set;} = false;
}
public class WordDictionary {
    private TrieNode _root;
    public WordDictionary() {
        _root = new();
    }
    
    public void AddWord(string word) {
        TrieNode curr = _root;
        foreach(char c in word)
        {
            if(!curr.Children.ContainsKey(c))
            {
                curr.Children[c] = new TrieNode();
            }
            curr = curr.Children[c];
        }
        curr.IsEndWord = true;
    }
    
    public bool Search(string word) {      
        return dfs(word, 0, _root);
    }

    public bool dfs(string word, int index, TrieNode root)
    {
        TrieNode curr = root;
        for(int i=index; i < word.Length; i++) 
        {
            char c = word[i];
            if(c == '.')
            {
                foreach(var child in curr.Children.Values)
                    if(dfs(word, i + 1, child))
                        return true;
                return false; 
            }
            if(curr.Children.ContainsKey(c)) 
            {
                curr = curr.Children[c];
            } 
            else
            {
                return false;
            }                     
        }
        return curr.IsEndWord;
    }
}