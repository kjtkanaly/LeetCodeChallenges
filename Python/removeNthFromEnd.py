# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:

        valList = []

        while head:
            valList.append(head.val)
            head = head.next

        valList.pop(len(valList) - n)

        valList.reverse()
        curr, prev = None, None

        for val in valList:
            curr = ListNode(val, prev)
            prev = curr

        return curr