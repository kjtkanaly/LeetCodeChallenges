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

    public int GlobalMax = int.MinValue;

    public int MaxPathSum(TreeNode root) {
        
        // Default
        if (root == null)
        {
            return 0;
        }
        
        Dig(root);
        
        return GlobalMax;
    }
    
    public int Dig(TreeNode root)
    {
        int Left = 0;
        int Right = 0;
        int Value = root.val;

        if (root.left != null)
        {
            Left = Dig(root.left);
        }

        if (root.right != null)
        {
            Right = Dig(root.right);
        }
        
        int MaxPath = Math.Max(Value, Value + Math.Max(Left + Right, Math.Max(Left, Right)));
        
        //Console.WriteLine(MaxPath);

        if (MaxPath > GlobalMax)
        {
            GlobalMax = MaxPath;
        }

        return Math.Max(Value, Value + Math.Max(Left, Right));

    }
}