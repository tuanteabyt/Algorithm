/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
          if(head==null||head.next==null) return false;
            ListNode temp=head.next;
            while(temp.next!=null){
                if(temp==head) return true;
                if(temp.next.next==null) return false;
                temp=temp.next.next;
                head=head.next;
            } 
            return false;
    }
}