/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) {
        
        int leftCount = 0;
        int rightCount = 0;
        
        TreeNode Left = root, Right = root;
        
        while (Left.left != null)
        {
            leftCount++;
            Left = Left.left;
        }
        
        while (Right.right != null)
        {
            rightCount++;
            Right = Right.right;
        }
        
        Console.WriteLine(leftCount);
        
        return (rightCount + leftCount);
    }
}