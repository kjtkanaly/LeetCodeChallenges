# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:

        seenVals = []

        while head:
            if head in seenVals:
                return True

            seenVals.append(head)
            head = head.next

        return False
