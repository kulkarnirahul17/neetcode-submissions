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
    int target = -1;
    int count;
    public int KthSmallest(TreeNode root, int k) {
        count = k;
        DFS(root);
        return target;
    }

    public void DFS(TreeNode root) {
        if(root == null || target != -1)
            return;
        DFS(root.left);
        count -- ;
        if(count == 0) 
        {
            target = root.val;
            return;
        }
        DFS(root.right);  
    }      
}