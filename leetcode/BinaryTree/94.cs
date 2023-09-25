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
    IList<int> a=new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        // if(root!=null){
        // InorderTraversal(root.left);
        // a.Add(root.val);
        // InorderTraversal(root.right);}
        // return a;
        TreeNode curr=root;
        TreeNode pre;
        while(curr !=null){
            if(curr.left==null){
                a.Add(curr.val);
                curr=curr.right;
            }
            else{
                pre=curr.left;
                while(pre.right!=null){
                    pre=pre.right;
                }
                pre.right =curr;
                TreeNode temp =curr;
                curr= curr.left;
                temp.left=null;
            }
        }
        return a;
    }
}