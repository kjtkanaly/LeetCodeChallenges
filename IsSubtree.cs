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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        
        // Finding the subroot in the root tree
        return FindingTheSubRoot(root, subRoot);
        
        /*// Check if the SubRoot is contained in the root
        if (root != null)
        {
            return CheckIfSubRootIsContained(root, subRoot);   
        }
        else
        {
            return false;   
        }*/
    }
    
    public bool CheckIfSubRootIsContained(TreeNode root, TreeNode subRoot)
    {
        if (root == null ^ subRoot == null)
        {
            return false;
        }
        
        if (root == null && subRoot == null)
        {
            return true;
        }
        
        if (root.val != subRoot.val)
        {
            return false;
        }
        if (root.left != null || subRoot.left != null)
        {
            if (CheckIfSubRootIsContained(root.left, subRoot.left) == false)
            {
                return false;
            }
        }
        if (root.right != null || subRoot.right != null)
        {
            if (CheckIfSubRootIsContained(root.right, subRoot.right) == false)
            {
                return false;
            }
        }
        
        return true;
    }
    
    public bool FindingTheSubRoot(TreeNode root, TreeNode subRoot)
    {               
        if (root.val == subRoot.val)
        {
            //Console.WriteLine("Root: " + root.val + ", SubRoot: " + subRoot.val);
            
            if (CheckIfSubRootIsContained(root, subRoot) == true)
            {
                return true;
            }
        }
        
        if (root.left != null)
        {
            if (FindingTheSubRoot(root.left, subRoot) == true)
            {
                return true;
            }
        }

        if (root.right != null)
        {
            if (FindingTheSubRoot(root.right, subRoot) == true)
            {
                return true;
            }
        }
        
        return false;
    }
}