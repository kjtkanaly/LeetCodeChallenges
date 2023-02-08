# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:

        # Default
        if not(root):
            return []

        Output = [[]]

        def Traverse(root, level):

            nonlocal Output

            if not(root):
                return

            Traverse(root.left, level + 1)
            Traverse(root.right, level + 1)

            while(len(Output) <= level):
                Output.append([])

            Output[level].append(root.val)

        Traverse(root, 0)

        return Output