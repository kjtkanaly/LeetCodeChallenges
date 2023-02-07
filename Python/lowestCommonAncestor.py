# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def lowestCommonAncestor(self, root: 'TreeNode', p: 'TreeNode', q: 'TreeNode') -> 'TreeNode':

        lca = None

        def digDown(root):

            nonlocal lca

            if not(root):
                return

            digDown(root.left)
            digDown(root.right)

            if p.val > q.val:
                if ((p.val >= root.val) and (q.val <= root.val)):
                    lca = root
            
            else:
                if ((p.val <= root.val) and (q.val >= root.val)):
                    lca = root
        
        digDown(root)
        return lca
