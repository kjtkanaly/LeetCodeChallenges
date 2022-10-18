/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    
    public List<TreeNode> tree, branch;
    
    TreeNode LCA = null;
    
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        tree = new List<TreeNode>();
        recordTreePreOrder(root, tree);
        
        for (int i = 0; i < tree.Count; i++)
        {

            branch = new List<TreeNode>();
            recordTreePreOrder(tree[i], branch);
            
            if ((branch.Contains(p)) && (branch.Contains(q)))
            {
                LCA = tree[i];
            }
        }
    
        return LCA; 
    }
    
    public void recordTreePreOrder(TreeNode node, List<TreeNode> path)
    {        
        if (node != null)
        {
            path.Add(node);
            recordTreePreOrder(node.left, path);
            recordTreePreOrder(node.right, path);   
        }
    }
}