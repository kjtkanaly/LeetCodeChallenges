# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:

        valL1 = []
        valL2 = []

        while l1:
            valL1.append(l1.val)
            l1 = l1.next

        while l2:
            valL2.append(l2.val)
            l2 = l2.next

        while len(valL1) < len(valL2):
            valL1.append(0)

        while len(valL2) < len(valL1):
            valL2.append(0)

        index = 0
        remainder = 0
        output = []

        while (index < len(valL1)):
            val = valL1[index] + valL2[index] + remainder
            ones = val % 10
            output.append(ones)

            remainder = val // 10

            index += 1

        if remainder > 0:
            output.append(remainder)

        output.reverse()

        curr, prev = None, None

        for val in output:
            curr = ListNode(val, prev)
            prev = curr

        return curr


        

