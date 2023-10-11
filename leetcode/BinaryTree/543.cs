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
    int res=0;
    public int DiameterOfBinaryTree(TreeNode root) {
        DiameterOfBinaryTree1(root);
        return res;
    }
     public int DiameterOfBinaryTree1(TreeNode root) {
        if(root==null) return 0;
        int left= DiameterOfBinaryTree1(root.left);
        int right=DiameterOfBinaryTree1(root.right);
        res= Math.Max(res,right+left);
        return 1+Math.Max(left,right);
    }
}