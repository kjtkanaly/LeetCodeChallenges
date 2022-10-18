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
    
    public List<int> GoodBoyList = new List<int>();
    
    public int GoodNodes(TreeNode root) {
        
        List<int> Path = new List<int>();
        
        TraverseTree(root, Path);
        
        return GoodBoyList.Count;        
    }
    
    public void TraverseTree(TreeNode root, List<int> Path)
    {
        Path.Add(root.val);
        
        bool GoodNode = true;
        
        for (int i = Path.Count - 2; i >= 0; i--)
        {
            if (Path[i] > root.val)
            {
                GoodNode = false;
                break;
            }
        }
        
        if (GoodNode == true)
        {
            GoodBoyList.Add(root.val);
        }
        
        //////////////////////////////////////////
        // Debug
        Console.WriteLine("Node: " + root.val);
        Console.WriteLine("Path Length: " + Path.Count);
        
        for (int i = Path.Count - 2; i >= 0; i--)
        {
            Console.WriteLine(Path[i]);
        }
        
        Console.WriteLine("Good :" + GoodNode);
        
        Console.Write("\n");
        //////////////////////////////////////////

        
        List<int> LeftPath = new List<int>();
        List<int> RightPath = new List<int>();
            
        LeftPath.AddRange(Path);
        RightPath.AddRange(Path);
        
        if (root.left != null)
        {
            TraverseTree(root.left, LeftPath);
        }
        
        if (root.right != null)
        {
            TraverseTree(root.right, RightPath);
        }
    }
}