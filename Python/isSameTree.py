# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isSameTree(self, p: Optional[TreeNode], q: Optional[TreeNode]) -> bool:

        pNodeCheck = not(p)
        qNodeCheck = not(q)

        if (pNodeCheck ^ qNodeCheck):
            return False

        if (pNodeCheck & qNodeCheck):
            return True
        
        if not(p.val == q.val):
            return False

        leftCheck = self.isSameTree(p.left, q.left)
        rightCheck = self.isSameTree(p.right, q.right)

        return (leftCheck & rightCheck)

        