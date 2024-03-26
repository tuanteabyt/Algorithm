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
    public void ReorderList(ListNode head) {
        if(head==null||head.next==null||head.next.next==null){
            return ;
        }
        ListNode  slow =head,fast=head;
        while(fast.next!=null&&fast.next.next!=null){
            slow=slow.next;
            fast=fast.next.next;
        }
        ListNode prev=null,mid=slow.next,tmp;
        while(mid!=null){
            tmp=mid.next;
            mid.next=prev;
            prev=mid;
            mid=tmp;
        }//dao mang tu mid
        slow.next=null;
        ListNode A = head, B=prev;
        while (A!=null && B!=null) {
            ListNode A_next=A.next;
            ListNode B_next=B.next;

            A.next=B;
            B.next=A_next;

            A=A_next;
            B=B_next;
        }
    }
}