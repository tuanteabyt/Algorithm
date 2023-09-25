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
    public TreeNode InvertTree(TreeNode root) {
        // TreeNode temp=null;
        // if(root==null) return root;
        // // temp=root.left;
        // // root.left=root.right;
        // // root.right=temp;
        // InvertTree(root.right);
        // InvertTree(root.left);
        // temp=root.left;
        // root.left=root.right;
        // root.right=temp;
        // return root;
         if(root != null)
        {
            var temp = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(temp);
        }
        
        return root;
    }
}