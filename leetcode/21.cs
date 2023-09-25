/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
       ListNode dummy = new ListNode(-1), p = dummy;
       ListNode p1 = list1, p2 = list2;
      ListNode temp=null;
        while(p1 != null && p2 != null){
          if(p1.val>p2.val){
            p.next=p2;
            p2=p2.next;
          }
          else{
            p.next=p1;
            p1=p1.next;
          }
         p = p.next;
        }
        if (p1 != null) {
        p.next = p1;
    }
    
    if (p2 != null) {
        p.next = p2;
    }
        return dummy.next;
    }
}