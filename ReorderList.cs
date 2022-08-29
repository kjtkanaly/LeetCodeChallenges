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

        // Defaults
        if (head.next == null)
        {
            return;
        }
        
        List<int> NodeValues = new List<int>();
        ListNode Node = null;
        
        if (head.next.next != null)
        {
            Node = head.next.next;   
        }
        else
        {
            return;
        }
        
        NodeValues.Add(head.val);
        NodeValues.Add(head.next.val);
        
        while (Node != null)
        {
            NodeValues.Add(Node.val);
            Node = Node.next;
        }
        
        int left = 1;
        while (left < NodeValues.Count - 1)
        {
            NodeValues.Insert(left, NodeValues[NodeValues.Count - 1]);
            NodeValues.RemoveAt(NodeValues.Count - 1);
            
            left+=2;
        }
        
        int index = 0;
        while (head != null)
        {
            head.val = NodeValues[index];
            head = head.next;
            index++;
        }
    }
}