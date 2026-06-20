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
    public bool HasPathSum(TreeNode root, int targetSum) {
        return HasPathSum(root, 0, targetSum);
    }

    public bool HasPathSum(TreeNode root, int total , int targetSum)
    {
        if(root == null)
            return false;
        total += root.val;
        if(root.left == null && root.right == null)
        {            
            if(total == targetSum)
                return true;
            return false;
        }
        return HasPathSum(root.left, total, targetSum) || HasPathSum(root.right, total, targetSum);
    }
}