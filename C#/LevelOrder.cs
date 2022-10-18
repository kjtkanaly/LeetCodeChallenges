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
    
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
        // Default
        if (root == null)
        {
            return new List<IList<int>>();
        }
        
        IList<IList<int>> Output    = new List<IList<int>>();
        List<int>         DepthList = new List<int>();
        
        ListChildren(root, DepthList);
        
        List<int> DistDepth = DepthList.Distinct().ToList();
        
        for (int i = 0; i < DistDepth.Count; i++)
        {
            int index = DepthList.IndexOf(DistDepth[i]);
            List<int> Input = new List<int>();
            
            while (index != -1)
            {
                Input.Add(TreeValues[index]);
                index = DepthList.IndexOf(DistDepth[i], index + 1);
            }
            
            Output.Add(Input);
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

/*
// Debug
        Console.Write("\n");
        foreach (int val in TreeValues)
        {
            Console.WriteLine(val);
        }
*/