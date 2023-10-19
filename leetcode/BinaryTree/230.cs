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
    // int[] a=new int[10000];
    // int i=0;
    // public int KthSmallest(TreeNode root, int k) {
    //     KthSmallest(root);
    //     return a[k-1];
    // }
    // public void KthSmallest(TreeNode root)
    //  {
    //   if(root==null) return ;
    //     KthSmallest(root.left);
    //     a[i++]=root.val;
    //     KthSmallest(root.right);
    // }

      public int KthSmallest(TreeNode root, int k) {
        // 利用 BST 的中序遍历特性
        traverse(root, k);
        return res;
    }

    // 记录结果
    int res = 0;
    // 记录当前元素的排名
    int rank = 0;
    void traverse(TreeNode root, int k) {
        if (root == null) {
            return;
        }
        traverse(root.left, k);
        /* 中序遍历代码位置 */
        rank++;
        if (k == rank) {
            // 找到第 k 小的元素
            res = root.val;
            return;
        }
        /*****************/
        traverse(root.right, k);
    }
}