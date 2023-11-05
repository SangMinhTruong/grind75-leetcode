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
        ListNode skipNode = head;

        while (skipNode != null && skipNode.next != null) {
            head = head.next;
            skipNode = skipNode.next.next;

            if (head == skipNode) {
                return true;
            }
        }

        return false;
    }
}