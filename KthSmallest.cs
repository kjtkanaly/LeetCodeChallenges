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
    
    public List<int> TreeValues = new List<int>();
    
    public int KthSmallest(TreeNode root, int k) {
        
        TraverseTree(root);
        
        for (int i = 0; i < k - 1; i++)
        {
            TreeValues.Remove(TreeValues.Min());
        }
        
        return TreeValues.Min();
    }
    
    public void TraverseTree(TreeNode root, int Depth = 0)
    {
        Depth++;

        TreeValues.Add(root.val);
        //Console.WriteLine("Node " + root.val + ": " + Depth);
        
        if (root.left != null)
        {
            TraverseTree(root.left, Depth);
        }
        
        if (root.right != null)
        {
            TraverseTree(root.right, Depth);
        }
        
        return;
    }
}