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
        
        List<int> Values = new List<int>();
        ListNode Node = head;
        int sz = 0;
        
        while (Node != null)
        {
            Values.Add(Node.val);
            
            sz++;
            Node = Node.next;
        }
        
        // Default
        if (sz == 1)
        {
            return null;
        }
        
        Values.RemoveAt(sz - n);
        
        ListNode PreviousNode = new ListNode(Values[Values.Count - 1], null);
        ListNode Output = PreviousNode;
        for (int i = Values.Count - 2; i > -1; i--)
        {
            Output = new ListNode(Values[i], PreviousNode);;
            PreviousNode = Output;
        }
        
        return Output;        
    }
}