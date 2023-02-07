# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isSubtree(self, root: Optional[TreeNode], subRoot: Optional[TreeNode]) -> bool:

        check = False

        def digDown(root):
            nonlocal check

            if not(root):
                return

            digDown(root.left)
            digDown(root.right)

            def compareTree(root, subRoot) -> bool:
                if not(root) and not(subRoot):
                    return True
                
                if root and subRoot and (root.val == subRoot.val):
                    return compareTree(root.left, subRoot.left) and compareTree(root.right, subRoot.right)
                else:
                    return False

            if compareTree(root, subRoot):
                check = True
                return

        digDown(root)
        return check