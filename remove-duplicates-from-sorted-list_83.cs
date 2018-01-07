/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null)
            return head;

        ListNode temp = head;
        while (temp.next != null )
        {
            if (temp.val == temp.next.val)
                temp.next = temp.next.next;
            else
                temp = temp.next;
        }

        return head;
    }
}