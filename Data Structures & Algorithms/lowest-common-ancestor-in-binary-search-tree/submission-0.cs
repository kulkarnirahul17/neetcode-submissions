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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null || p == null || q == null) {
            return null;
        }
        if(p.val > root.val && q.val > root.val) // Both p and q are greater so, it falls on right
        {
            return LowestCommonAncestor(root.right, p, q);
        }
        else if(p.val < root.val && q.val < root.val) // Both are smaller than root, so it falls on left
        {
            return LowestCommonAncestor(root.left, p, q);            
        }
        else {
            return root;
        }
    }
}
