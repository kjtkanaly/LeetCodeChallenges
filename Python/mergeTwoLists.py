# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:

        valList = []

        while list1 and list2:

            if (list1.val < list2.val):
                valList.append(list1.val)
                list1 = list1.next
            else:
                valList.append(list2.val)
                list2 = list2.next

        while list1:
            valList.append(list1.val)
            list1 = list1.next

        while list2:  
            valList.append(list2.val)
            list2 = list2.next

        valList.reverse()

        curr, prev = None, None

        for val in valList:
            curr = ListNode(val, prev)
            prev = curr

        return curr
