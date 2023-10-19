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
    int sum =0;
    public TreeNode BstToGst(TreeNode root) {
        BstToGst1(root);
        return root;
    }
     public void BstToGst1(TreeNode root) {
        if(root==null) return ;
        BstToGst1(root.right);
        sum+=root.val;
        root.val=sum;
        BstToGst1(root.left);
    }
}