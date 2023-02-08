# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def goodNodes(self, root: TreeNode) -> int:

        goodNodeCount = 0

        def checkForGoodNodes(root, path):

            nonlocal goodNodeCount

            if not(root):
                return

            goodNodeCount += 1

            # Check if path is valid
            for val in path:
                if val > root.val:
                    goodNodeCount -= 1
                    break

            # Add current node to path
            path.append(root.val)

            checkForGoodNodes(root.left, path)
            checkForGoodNodes(root.right, path)

            path.pop()

        checkForGoodNodes(root, [])

        return goodNodeCount