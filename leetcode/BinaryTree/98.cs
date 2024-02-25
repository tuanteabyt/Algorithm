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
    public bool IsValidBST(TreeNode root) {
     return IsValidBST(root,null,null);
    }
    public bool IsValidBST(TreeNode root,TreeNode Min,TreeNode Max){
    if(root==null) return true;
    if(Min!=null && root.val<=Min.val) return false;
    if(Max!=null && root.val>=Max.val) return false;
    return IsValidBST(root.left,Min,root)&&IsValidBST(root.right,root,Max);
    }
}