/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> result = new();
        if(root == null)
            return result;
        
        Queue<TreeNode> qu = new();
        qu.Enqueue(root);
        while(qu.Count > 0) 
        { 
            List<int> levelList = new();  
            int count = qu.Count;         
            for(int i=0; i < count; i++) 
            {              
                TreeNode curr = qu.Dequeue();
                levelList.Add(curr.val);
                if(curr.left != null)
                    qu.Enqueue(curr.left);
                if(curr.right != null) 
                    qu.Enqueue(curr.right);
            }
            if(levelList.Count > 0) {
                result.Add(levelList);
            }            
        }        
        return result;
    }
}
