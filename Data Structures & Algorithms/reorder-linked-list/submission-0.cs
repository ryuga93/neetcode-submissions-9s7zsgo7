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
        var slow = head;
        var fast = head.next;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode list2 = slow.next;
        slow.next = null;
        ListNode previous = null;

        while (list2 != null)
        {
            ListNode tempNext = list2.next;
            list2.next = previous;
            previous = list2;
            list2 = tempNext;
        }

        list2 = previous;
        ListNode list1 = head;

        while (list2 != null)
        {
            ListNode temp1 = list1.next;
            ListNode temp2 = list2.next;

            list1.next = list2;
            list2.next = temp1;
            list1 = temp1;
            list2 = temp2;
        }
    }
}
