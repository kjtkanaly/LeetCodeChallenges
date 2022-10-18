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
        
        int sum = l1.val + l2.val;
            
        if (sum >= 10)
        {
            sum -= 10;
            if (l1.next != null)
            {
                l1.next.val += 1;   
            }
            else
            {
                l1.next = new ListNode(1, null);
            }
        }
        
        ListNode output = new ListNode(sum);
        
        if ((l1.next != null) || (l2.next != null))
        {
            if (l1.next == null)
            {
                l1.next = new ListNode(0, null);
            }
            if (l2.next == null)
            {
                l2.next = new ListNode(0, null);
            }
            
            output.next = AddTwoNumbers(l1.next, l2.next);   
        }
        
        return output;    
    }
}