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
        
        int RootIndexInOrder = Array.IndexOf(inorder,RootValue);
        Console.WriteLine("Root Index: " + RootIndexInOrder);
        
        // Initalize Nodes
        List<TreeNode> Nodes = new List<TreeNode>(inorder.Length);
        for (int i = 0; i < inorder.Length; i++)
        {
            Nodes.Add(new TreeNode(inorder[i]));
        }
        
        // Default 2 electric boogaloo
        if (inorder.Length == 2)
        {
            if (RootIndexInOrder == 1)
            {
                Nodes[1].left = Nodes[0];
                return Nodes[1];
            }
            else
            {
                Nodes[0].right = Nodes[1];
                return Nodes[0];
            }
        }
        
        Console.Write("\n");
        
        if (RootIndexInOrder != 0)
        {
            int Left = 1;
            while (Nodes[Left].val != RootValue && Nodes[Left + 1].val != RootValue)
            {
                Nodes[Left].left = Nodes[Left - 1];
                Nodes[Left].right = Nodes[Left + 1];

                Nodes.RemoveAt(Left + 1);
                Nodes.RemoveAt(Left - 1);
            }
        }

        Console.WriteLine("beep");
        
        if (RootIndexInOrder != inorder.Length - 1)
        {
            int Right = Nodes.Count - 2;
            while (Nodes[Right].val != RootValue && Nodes[Right - 1].val != RootValue)
            {
                Nodes[Right].left = Nodes[Right - 1];
                Nodes[Right].right = Nodes[Right + 1];

                Nodes.RemoveAt(Right + 1);
                Nodes.RemoveAt(Right - 1);

                Right = Nodes.Count - 2;
            }
        }
        
        Nodes[1].left = Nodes[0];   
        Nodes[1].right = Nodes[2];   
        Nodes.RemoveAt(0);
        Nodes.RemoveAt(1);

        
        return Nodes[0];
    }
}