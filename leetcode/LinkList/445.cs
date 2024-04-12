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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
       Stack<int> s1=new Stack<int>();
       Stack<int> s2=new Stack<int>();
       Stack<int> myStack = new Stack<int>();
       ListNode head1=l1,head2=l2;
       int tmp=0,add=0;
       while(head1!=null){
        s1.Push(head1.val);
        head1=head1.next;
       }
        while(head2!=null){
        s2.Push(head2.val);
        head2=head2.next;
       }
        while(s1.Count()>0||s2.Count()>0){
        int top1=s1.Count()>0?s1.Pop():0;
        int top2=s2.Count()>0?s2.Pop():0;
        tmp=top1+top2+tmp;
        add=tmp%10;
        tmp=tmp/10;
        myStack.Push(add);
       }
       if(tmp==1) myStack.Push(tmp);
       ListNode resList = new ListNode(myStack.Pop(), null);
       ListNode prv = resList;
    while(myStack.Count() > 0)
        {
            prv.next = new ListNode(myStack.Pop(), null);
            prv = prv.next;
        }

        return resList;
    }
}