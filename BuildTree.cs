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
 
            Console.WriteLine("Node: " + Nodes[Left].val);    
            Console.WriteLine("Left: " + Nodes[Left - 1].val);    
            Console.WriteLine("Right: " + Nodes[Left + 1].val);    
            Console.Write("\n");
 */
public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        
        // Default
        if (inorder.Length == 1)
        {
            return new TreeNode(preorder[0]);
        }
        
        int RootValue = preorder[0];
        
        int RootNodeIndex = Array.IndexOf(inorder,RootValue);
        Console.WriteLine("Root Index: " + RootNodeIndex);
        Console.Write("\n");
        
        // Initalize Nodes
        List<TreeNode> Nodes = new List<TreeNode>(inorder.Length);
        for (int i = 0; i < inorder.Length; i++)
        {
            Nodes.Add(new TreeNode(inorder[i]));
        }        
        
           
        if (RootNodeIndex > 1)
        {
            int Left = 1;
            
            if (RootNodeIndex == 2 && Nodes.Count == 3 && Nodes[0].val < Nodes[1].val)
            {
                Left = 0;
            }
            
            while (Left != RootNodeIndex)
            {

                if (Left + 1 != RootNodeIndex)
                {
                    Nodes[Left].right = Nodes[Left + 1];
                    Nodes.RemoveAt(Left + 1);
                    RootNodeIndex--;
                }
                else
                {
                    Nodes[Left].right = null;
                }
                
                
                if (Left == 1)
                {
                    Nodes[Left].left = Nodes[Left - 1];
                    Nodes.RemoveAt(Left - 1);
                    RootNodeIndex--;
                }
                else
                {
                    Nodes[Left].left = null;
                }
                
                if (Left == 0)
                {
                    Left = 1;
                }
                
            }   
        }
        
        if (RootNodeIndex < Nodes.Count - 2)
        {
            int Right = Nodes.Count - 2;
            
            if ((RootNodeIndex == 0) && Nodes.Count == 3 && Nodes[Nodes.Count - 1].val < Nodes[Nodes.Count - 2].val)
            {
                Right = Nodes.Count - 1;
            }
             
            while (Right != RootNodeIndex)
            {
                
                if (Right + 1 < Nodes.Count)
                {
                    Nodes[Right].right = Nodes[Right + 1];
                    Nodes.RemoveAt(Right + 1);
                }
                else
                {
                    Nodes[Right].right = null;
                }
                
                if (Right - 1 != RootNodeIndex)
                {
                    Nodes[Right].left = Nodes[Right - 1];
                    Nodes.RemoveAt(Right - 1);
                }
                else
                {
                    Nodes[Right].left = null;
                }
                
                Right = Nodes.Count - 2;
            }
        }

        Console.WriteLine("Root Index: " + RootNodeIndex);
        
        if (RootNodeIndex != Nodes.Count - 1)
        {
            Nodes[RootNodeIndex].right = Nodes[RootNodeIndex + 1];     
            Nodes.RemoveAt(RootNodeIndex + 1);   
        }
        
        if (RootNodeIndex != 0)
        {
            Nodes[RootNodeIndex].left = Nodes[RootNodeIndex - 1];       
            Nodes.RemoveAt(RootNodeIndex - 1);
        }       
        
        return Nodes[0];
    }
}