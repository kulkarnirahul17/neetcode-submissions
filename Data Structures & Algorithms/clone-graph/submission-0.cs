/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) return null;
        Dictionary<Node, Node> map = new();
        Queue<Node> queue = new();  

        queue.Enqueue(node);
        map.Add(node, new Node(node.val));

        while(queue.Count > 0)
        {
            var curr = queue.Dequeue();
            
            //Loop through all neighbors and add
            foreach(var neighbor in curr.neighbors)
            {
                if(!map.ContainsKey(neighbor))
                {
                    map.Add(neighbor, new Node(neighbor.val));
                    queue.Enqueue(neighbor);
                }
                map[curr].neighbors.Add(map[neighbor]);
            }
        }
        return map[node];
    }
}