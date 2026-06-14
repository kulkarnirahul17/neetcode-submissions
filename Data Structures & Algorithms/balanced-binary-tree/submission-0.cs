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
    public bool IsBalanced(TreeNode root) {
        return IsBalancedWithHeight(root).Item2;        
    }

   public (int, bool) IsBalancedWithHeight(TreeNode root)
   {
        if(root == null) {
            return (0, true);
        }
        var  leftHeight = IsBalancedWithHeight(root.left);
        var rightHeight = IsBalancedWithHeight(root.right);
        
        bool balanced = leftHeight.Item2 && rightHeight.Item2;
        int heightDiff = Math.Abs(leftHeight.Item1 - rightHeight.Item1);

        balanced = balanced && heightDiff < 2;

        return (1 + Math.Max(leftHeight.Item1, rightHeight.Item1), balanced);
   }
   
}
