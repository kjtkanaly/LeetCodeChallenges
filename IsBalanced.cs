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
    
    public bool Output = true;
    
    public bool IsBalanced(TreeNode root) {
        
        // Default
        if (root == null)
        {
            return true;
        }
        
        Dig(root);
        
        return Output;
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
        
        if (Math.Abs(Left - Right) >= 2)
        {
            Output = false;
        }
        
        int Height = 1 + Math.Max(Left,Right);
        
        //Console.WriteLine("Val " + root.val + ": " + Height + " -> " + Left + "," + Right);
        
        return Height;
    }
}