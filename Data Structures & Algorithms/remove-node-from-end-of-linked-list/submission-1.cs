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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
       ListNode prev = null;
        ListNode curr = head;
        //First count how many nodes in List
        int count = 0;
        while(curr != null)
        {
            curr = curr.next;
            count ++;
        }
        //If head needs to be removed;
        if(count - n == 0) {
            return head.next;
        }
        curr = head;
        for(int i = 0; i < count - n; i ++) {
            prev = curr;
            curr = curr.next;
        }
       
        if(curr != null)
        {
            prev.next = curr.next;
        }
        return head;
    }
}
