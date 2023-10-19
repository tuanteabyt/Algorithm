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
    public TreeNode DeleteNode(TreeNode root, int key) {
       if (root == null) return null;
        if (root.val == key) {
            if (root.left == null) return root.right;
            if (root.right == null) return root.left;
            TreeNode minNode = getMin(root.right);
            root.right = DeleteNode(root.right, minNode.val);
            minNode.left = root.left;
            minNode.right = root.right;
            root = minNode;
        } else if (root.val > key) {
            root.left = DeleteNode(root.left, key);
        } else if (root.val < key) {
            root.right = DeleteNode(root.right, key);
        }
        return root;
    }
    TreeNode getMin(TreeNode node) {
        while (node.left != null) node = node.left;
        return node;
    }
}