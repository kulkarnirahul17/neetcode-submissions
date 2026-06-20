 public class TrieNode
{
    public bool IsEndWord { get; set; } = false;
    public Dictionary<char, TrieNode> Children { get; set; } = new();
}
public class PrefixTree {
    TrieNode Root { get; set; }
    public PrefixTree() {             
        Root = new TrieNode
        {
            Children = []
        };        
    }
    
    public void Insert(string word) {
        TrieNode curr = Root;
        foreach (var c in word)
        {
            if (!curr.Children.ContainsKey(c))
            {
                curr.Children[c] = new TrieNode();
            }
            curr = curr.Children[c];
        }
        curr.IsEndWord = true;
    }
    
    public bool Search(string word) {
        TrieNode curr = Root;
        foreach (var c in word)
        {
            if (!curr.Children.ContainsKey(c))
            {
                return false;
            }
            curr = curr.Children[c];
        }
        return curr.IsEndWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode curr = Root;
        foreach (var c in prefix)
        {
            if (!curr.Children.ContainsKey(c))
            {
                return false;
            }
            curr = curr.Children[c];
        }
        return true;
    }
}
