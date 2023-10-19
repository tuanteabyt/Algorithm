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
    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder) {
        int n=preorder.Length;
        for(int i=0;i<n;i++){
            valtoIndex.Add(postorder[i],i);
        }
     return build(preorder, 0, n- 1,postorder, 0, n- 1);
    }
    TreeNode build(int[] preorder, int preStart, int preEnd, 
            int[] postorder, int postStart, int postEnd) {
            if(preStart>preEnd) return null;
            if (preStart == preEnd) {
            return new TreeNode(preorder[preStart]);
        }
            int rootval=preorder[preStart];
            int rootLeftVal=preorder[preStart+1];
            int index=valtoIndex[rootLeftVal];
            int leftSize=index-postStart+1;
            TreeNode root=new TreeNode(rootval);
            root.left=build(preorder, preStart+1,preStart+leftSize, postorder, postStart, index-1);
            root.right=build(preorder, preStart+leftSize+1,preEnd, postorder, index+1, postEnd-1);
            return root;
            
               }
}