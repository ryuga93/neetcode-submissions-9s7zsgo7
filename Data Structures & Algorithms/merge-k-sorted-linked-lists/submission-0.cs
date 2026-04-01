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
        if (lists.Length == 0)
        {
            return null;
        }

        var minHeap = new PriorityQueue<ListNode, int>();

        foreach (var list in lists)
        {
            if (list != null)
            {
                minHeap.Enqueue(list, list.val);
            }
        }

        ListNode dummy = new ListNode(0);
        var current = dummy;
        while (minHeap.Count > 0)
        {
            var node = minHeap.Dequeue();
            current.next = node;
            node = node.next;
            current = current.next;

            if (node != null)
            {
                minHeap.Enqueue(node, node.val);
            }
        }
        
        return dummy.next;
    }
}
