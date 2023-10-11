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

     public int MinDepth(TreeNode root) {
        if(root==null) return 0;
        Queue<TreeNode> q=new Queue<TreeNode>();
        q.Enqueue(root);
        int depth=1;
        while(q.Count()!=0){
            int sz=q.Count();
            for(int i=0;i<sz;i++){
                TreeNode cur=q.Dequeue();
                if(cur.left==null && cur.right==null)
                return depth;
                if(cur.left!=null){
                    q.Enqueue(cur.left);
                }
                if(cur.right!=null){
                    q.Enqueue(cur.right);
                }             
            }
            depth++;
        }
        return depth;
    }
}