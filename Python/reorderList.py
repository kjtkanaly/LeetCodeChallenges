# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        """
        Do not return anything, modify head in-place instead.
        """
        valList = []
        curr = head

        while curr:
            valList.append(curr.val)
            curr = curr.next

        n, index = len(valList), 1
        while (index < n):
            valList.insert(index, valList[n - 1])
            valList.pop()
            index += 2

        for val in valList:
            head.val = val
            head = head.next
