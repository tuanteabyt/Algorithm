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
  IList<int> res=new List<int>(); 
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
      List<int> list1=new List<int>();
      int i=0,j=0;
      List<int> list2=new List<int>();
      Ans(root1,list1);
      Ans(root2,list2);
      while (i < list1.Count && j < list2.Count)
        {
            if (list1[i] <= list2[j])
            {
                res.Add(list1[i]);
                i++;
            }
            else
            {
                res.Add(list2[j]);
                j++;
            }
        }

        while (i < list1.Count)
        {
            res.Add(list1[i++]);
        }

        while (j < list2.Count)
        {
            res.Add(list2[j++]);
        }
      return res;
    }
     private void Ans(TreeNode root, List<int> list) {
      if (root == null) return;
      Ans(root.left,list);
      list.Add(root.val);
      Ans(root.right,list);
    }
}