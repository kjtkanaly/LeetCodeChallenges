# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def diameterOfBinaryTree(self, root: Optional[TreeNode]) -> int:

        diam = 0

        def diamOfRoot(root) -> int:

            nonlocal diam

            if not(root):
                return 0
            
            left = diamOfRoot(root.left)
            right = diamOfRoot(root.right)

            diam = max(diam, left + right)

            return 1 + max(left, right)

        diamOfRoot(root)

        return diam