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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        // Default
        if (list1 == null && list2 == null)
        {
            return null;
        }
        
        List<int> Nodes = new List<int>();
        ListNode Output = new ListNode();
        
        while ((list1 != null) && (list2 != null))
        {
            if (list1.val <= list2.val)
            {
                Nodes.Add(list1.val);
                list1 = list1.next;
            }
            else
            {
                Nodes.Add(list2.val);
                list2 = list2.next;
            }
        }
        
        while (list1 != null)
        {
            Nodes.Add(list1.val);
            list1 = list1.next;
        }
        
        while (list2 != null)
        {
            Nodes.Add(list2.val);
            list2 = list2.next;
        }
        
        ListNode butt = new ListNode(Nodes[Nodes.Count - 1], null);
        
        for (int i = Nodes.Count - 2; i > -1; i--)
        {
            Output = new ListNode(Nodes[i], butt);
            butt = Output;
        }
        
        return Output;
        
    }
}