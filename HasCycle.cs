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
        
        if (head == null)
        {
            return false;
        }
        
        List<ListNode> NodeList = new List<ListNode>();
        
        while (head != null)
        {
            if (NodeList.Contains(head))
            {
                return true;
            }
            
            NodeList.Add(head);
            head = head.next;
        }
        
        return false;
    }
}