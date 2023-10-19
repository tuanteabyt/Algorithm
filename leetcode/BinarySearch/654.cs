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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return build(nums,0,nums.Length-1);
    }
    TreeNode build(int[]nums,int left,int right){
        if(left>right) return null;
        int index=-1,maxVal = Int32.MinValue;
        for(int i=left;i<=right;i++){
            if(maxVal<nums[i]){
                index=i;
                maxVal=nums[i];
            }
        }
        TreeNode root=new TreeNode(maxVal);
        root.left=build(nums,left,index-1);
        root.right=build(nums,index+1,right);
        return root;
    } 
}