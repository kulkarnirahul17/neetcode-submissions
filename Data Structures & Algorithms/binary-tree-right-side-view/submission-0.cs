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
            TreeNode rightSide = null;
            int count = queue.Count();
            for(int i = 0; i < count; i++) {
                TreeNode curr = queue.Dequeue();
                if(curr != null) {
                    rightSide = curr;
                    queue.Enqueue(curr.left);
                    queue.Enqueue(curr.right);
                }
            }
            if(rightSide !=null)
                result.Add(rightSide.val);
        }
        return result;
    }
}
