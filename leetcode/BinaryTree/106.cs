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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
         int n=inorder.Length;
        for(int i=0;i<n;i++){
            valtoIndex.Add(inorder[i],i);
        }
        return build(postorder, 0,n-1, inorder, 0, n-1);
        //return build(inorder, 0, n-1,postorder, 0,n-1);
    }
    TreeNode build(int[] postorder, int postStart, int postEnd, 
               int[] inorder, int inStart, int inEnd) {
            if(inStart>inEnd) return null;
            int rootval=postorder[postEnd];
            int index=valtoIndex[rootval];
            int leftSize=index-inStart;
            TreeNode root=new TreeNode(rootval);
            root.left=build(postorder,postStart ,postStart+leftSize-1, inorder, inStart, index-1);
            root.right=build(postorder, postStart+leftSize,postEnd-1, inorder, index+1, inEnd);
            return root;
            
               }
//     TreeNode build(int[] inorder, int inStart, int inEnd,
//                 int[] postorder, int postStart, int postEnd) {

//         if (inStart > inEnd) {
//             return null;
//         }
//         // root 节点对应的值就是后序遍历数组的最后一个元素
//         int rootVal = postorder[postEnd];
//         // rootVal 在中序遍历数组中的索引
//         int index = valtoIndex[rootVal];
//         // 左子树的节点个数
//         int leftSize = index - inStart;
//         TreeNode root = new TreeNode(rootVal);



//         // 递归构造左右子树
//         root.left = build(inorder, inStart, index - 1,
//                          postorder, postStart, postStart + leftSize - 1);
        
//         root.right = build(inorder, index + 1, inEnd,
//                           postorder, postStart + leftSize, postEnd - 1);
//         return root;
// }
}