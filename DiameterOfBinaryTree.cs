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
    
    public int MaxValue = 0;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        
        Dig(root);
        
        return MaxValue;
    }
    
    public int Dig(TreeNode root)
    {   
        int Left = -1;
        int Right = -1;
        
        if (root.left != null)
        {
            Left = Dig(root.left);
        }
        
        if (root.right != null)
        {
            Right = Dig(root.right);
        } 
        
        int Height = 1 + Math.Max(Left,Right);
        
        MaxValue = Math.Max(MaxValue, Left + Right + 2);
        
        //Console.WriteLine("Val " + root.val + ": " + Height + " Diam: " + (Left + Right + 2));
        
        return Height;
    }
}