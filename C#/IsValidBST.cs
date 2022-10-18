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
    public bool IsValidBST(TreeNode root) {
        
        if (root.left != null)
        {
            if(checkValidity(root.left, null, root.val) == false)
            {
                return false;
            }
        }
        
        if (root.right != null)
        {
            if(checkValidity(root.right, root.val, null) == false)
            {
                return false;
            }
        }
        
        return true;
    }
    
    public bool checkValidity(TreeNode root, int? min, int? max)
    {
        if ((root.val <= min) || (root.val >= max))
        {
            return false;
        }        
        
        if (root.left != null)
        {
            if(checkValidity(root.left, min, root.val) == false)
            {
                return false;
            }
        }
        
        if (root.right != null)
        {
            if(checkValidity(root.right, root.val, max) == false)
            {
                return false;
            }
        }
        
        return true;
    }
	
}