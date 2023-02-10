# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:

        output = None

        def flipList(head, previous):

            nonlocal output

            if not(head):
                output = previous
                return

            Node = ListNode(head.val, previous)
            flipList(head.next, Node)

        flipList(head, None)
        return output