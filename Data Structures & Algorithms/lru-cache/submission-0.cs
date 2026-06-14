public class LRUCache {
    public class Node {
        public int key;
        public int val;        
        public Node next;
        public Node prev;                

        public Node(int key=0, int val=0, Node next=null, Node prev=null) {
            this.val = val;
            this.key = key;
            this.next = next;
            this.prev = prev;            
        }
    }

    Dictionary<int, Node> _cache;
    public Node left;
    public Node right;
    private int _capacity;

    public LRUCache(int capacity) {
        _cache = new Dictionary<int, Node>(capacity); 
        _capacity = capacity;  
        left = new();
        right = new();
        left.next = right;
        right.prev = left;            
    }
    
    private void Remove(Node node) {
        Node prev = node.prev;
        Node next = node.next;
        prev.next = next;
        next.prev = prev;
        //node = null;
    }

    private void Insert(Node node) {
        Node prev = right.prev;
        prev.next = node;
        node.next = right;
        node.prev = prev;   
        right.prev = node;
    }
    public int Get(int key) {
        if(_cache.ContainsKey(key))
        {
            Node node = _cache[key];
            Remove(node);
            Insert(node);
            return node.val; 
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        // If the key is already in cache, just update the most recently pointers.
        if(_cache.ContainsKey(key)) 
        {
            Remove(_cache[key]);
        }
        Node newNode = new Node(key, value);         
        _cache[key] = newNode;
        Insert(newNode);

        // If cache capacity is already reached
        if(_cache.Count > _capacity) {
            Node lru = left.next;
            Remove(lru);
            _cache.Remove(lru.key);
        }       
        
    }
}
