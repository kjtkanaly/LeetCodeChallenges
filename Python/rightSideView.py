# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:

        output = []

        def findRighSide(root, level = 0):

            nonlocal output

            if not(root):
                return

            findRighSide(root.left, level + 1)
            findRighSide(root.right, level + 1)

            while len(output) <= level:
                output.append(None)

            output[level] = root.val

        findRighSide(root, 0)

        return output