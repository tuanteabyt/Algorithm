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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
        ListNode head1=list1,tmp=list1,head2=list2;
        int count1=0,count2=0;
         while(count2<b+1){
                tmp=tmp.next;
                count2++;
        }
        while(head1!=null&&head2!=null){
             if(count1<a-1){
                head1=head1.next;
                count1++;
             }
             else{
                head1.next=head2;
                head1=head1.next;
                head2=head2.next;
             }
        }
        head1.next=tmp;
        return list1;
    }
}