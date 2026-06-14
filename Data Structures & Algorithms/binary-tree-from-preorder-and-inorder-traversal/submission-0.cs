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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if(preorder.Length == 0 || inorder.Length == 0) {
            return null;
        }
        return BuildTreeHelper(preorder, 0, preorder.Length -1, 
                                inorder, 0, inorder.Length -1);
    }

    public TreeNode BuildTreeHelper(int[] preorder, int preorderStart, int preorderEnd, 
                                    int[] inorder, int inorderStart, int inorderEnd)
    {
        if(preorderStart > preorderEnd || inorderStart > inorderEnd)
            return null;
        
        TreeNode root = new TreeNode(preorder[preorderStart]);

        // Find the index in inorder of the root in inorder;
        int mid = Array.IndexOf(inorder, root.val);
        
        // Everything to the left goes in left subtree. So, get the length of the left subtree.
        // Left start and end
        int leftTreeSize = mid - inorderStart;
        root.left = BuildTreeHelper(preorder, preorderStart + 1, preorderStart + leftTreeSize,
        inorder, inorderStart, mid -1);

        // Everything to the right goes in right subtree. So, get the length of the right subtree
        // Right start and end
        root.right = BuildTreeHelper(preorder, preorderStart + 1 + leftTreeSize, preorderEnd,
        inorder, mid+1, inorderEnd);
        
        return root;
    }

}