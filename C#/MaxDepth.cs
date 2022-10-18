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
    
    public int MaxDepth(TreeNode root, int Depth = 0) {
        
        if (root == null)
        {
            return 0;
        }
        
        Depth++;
        
        //Console.WriteLine("Node " + root.val + ": " + Depth);
        
        int RightDepth = Depth;
        int LeftDepth = Depth;
        
        if (root.left != null)
        {
            LeftDepth = MaxDepth(root.left, Depth);
        }
        
        if (root.right != null)
        {
            RightDepth = MaxDepth(root.right, Depth);
        }
        
        return Math.Max(RightDepth, LeftDepth);
        
    }
}