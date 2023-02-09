# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def kthSmallest(self, root: Optional[TreeNode], k: int) -> int:

        rootValues = []

        def findKSmall(root):

            nonlocal rootValues

            if not(root):
                return

            findKSmall(root.left)
            findKSmall(root.right)

            rootValues.append(root.val)

        findKSmall(root)

        rootValues.sort()

        # print(rootValues)

        return rootValues[k - 1]