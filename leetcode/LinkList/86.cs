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
    public ListNode Partition(ListNode head, int x) {
    ListNode dummy1 = new ListNode(-1);
    ListNode dummy2 = new ListNode(-1);
    ListNode p=head,p1=dummy1,p2=dummy2;
    while(p!=null){
      if(p.val<x) {
        p1.next=p;
        p1=p1.next;
        }
      else {
         p2.next=p;
         p2=p2.next;
      }
       ListNode temp = p.next;
        p.next = null;
        p = temp;
    }
    p1.next=dummy2.next;
    return dummy1.next;
    }
}