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
    public ListNode MergeKLists(ListNode[] lists) {
          if (lists.Length == 0) return null;
    ListNode dummy = new ListNode(-1);
    ListNode p = dummy;
    PriorityQueue<ListNode> pq = new PriorityQueue<>(
        lists.Length, (a, b)->(a.val - b.val));
    for (ListNode head : lists) {
        if (head != null)
            pq.add(head);
    }
    while (!pq.isEmpty()) {
        ListNode node = pq.poll();
        p.next = node;
        if (node.next != null) {
            pq.add(node.next);
        }
        p = p.next;
    }
    return dummy.next;
    }
}