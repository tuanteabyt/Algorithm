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
    Dictionary<int, int> valtoIndex = new Dictionary<int, int>();
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int n=inorder.Length;
        for(int i=0;i<n;i++){
            valtoIndex.Add(inorder[i],i);
        }
        return build(preorder, 0,n-1, inorder, 0, n-1);
    }
    TreeNode build(int[] preorder, int preStart, int preEnd, 
               int[] inorder, int inStart, int inEnd) {
            if(preStart>preEnd) return null;
            int rootval=preorder[preStart];
            int index=valtoIndex[rootval];
            int leftSize=index-inStart;
            TreeNode root=new TreeNode(rootval);
            root.left=build(preorder, preStart+1,preStart+leftSize, inorder, inStart, index-1);
            root.right=build(preorder, preStart+leftSize+1,preEnd, inorder, index+1, inEnd);
            return root;
            
               }
}