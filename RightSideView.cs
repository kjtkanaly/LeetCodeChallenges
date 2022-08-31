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
    
    public IList<int> RightSideView(TreeNode root) {
        
        // Default
        if (root == null)
        {
            return new List<int>();
        }
        
        List<int> Output    = new List<int>();
        List<int> DepthList = new List<int>();
        
        ListChildren(root, DepthList);
        
        List<int> DistDepth = DepthList.Distinct().ToList();
        
        for (int i = 0; i < DistDepth.Count; i++)
        {
            int index = DepthList.LastIndexOf(DistDepth[i]);
           
            Output.Add(TreeValues[index]);
        }
        
        return Output;
    }
    
    public void ListChildren(TreeNode root, List<int> DepthList, int Depth = 0)
    {
        Depth++;
        
        DepthList.Add(Depth);
        TreeValues.Add(root.val);
        
        //Console.WriteLine("Node " + root.val + ": " + Depth);
        
        if (root.left != null)
        {
            ListChildren(root.left, DepthList, Depth);
        }
        
        if (root.right != null)
        {
            ListChildren(root.right, DepthList, Depth);
        }
        
        return;
    }
}