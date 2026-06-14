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
    public List<int> RightSideView(TreeNode root) {
        List<int> result = [];
        if(root == null)
            return result;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);          
        while(queue.Count > 0) {            
            int count = queue.Count();
            for(int i = 0; i < count; i++) {
                TreeNode curr = queue.Dequeue();
                if(i == count - 1) 
                    result.Add(curr.val);
                if(curr.left != null)
                    queue.Enqueue(curr.left);
                if(curr.right != null) 
                    queue.Enqueue(curr.right);
            }                        
        }
        return result;
    }
}
