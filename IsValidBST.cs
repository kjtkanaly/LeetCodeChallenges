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
		
		// Checking Left Nodes
		if (root.left != null)
		{	
            if (IsValidBST(root.left) == false)
            {
                return false;
            }
            
            if (root.left.val >= root.val)
            {
                return false;
            }
            
			if(checkLeftLeaves(root.left, root.val) == false)
            {
                return false;
            }
            
		}
        
        // Checking Right Nodes
		if (root.right != null)
		{	
            if (IsValidBST(root.right) == false)
            {
                return false;
            }
            
            if (root.right.val <= root.val)
            {
                return false;
            }
            
			if(checkRightLeaves(root.right, root.val) == false)
            {
                return false;
            }
            
		}
		
		return true;
        
    }
	
	public bool checkLeftLeaves(TreeNode node, int rootValue)
	{
		bool flag = true;
		
		if (node.val >= rootValue)
		{
			flag = false;
		}
		
		if ((node.left != null) && (flag == true))
		{
			flag = checkLeftLeaves(node.left, rootValue);
		}
		
		if ((node.right != null) && (flag == true))
		{
			flag = checkLeftLeaves(node.right, rootValue);
		}
		
		return flag;
	}
    
    public bool checkRightLeaves(TreeNode node, int rootValue)
	{
		bool flag = true;
		
        Console.WriteLine(node.val);
        
		if (node.val <= rootValue)
		{
			flag = false;
		}
		
		if ((node.left != null) && (flag == true))
		{
			flag = checkRightLeaves(node.left, rootValue);
		}
		
		if ((node.right != null) && (flag == true))
		{
			flag = checkRightLeaves(node.right, rootValue);
		}
		
		return flag;
	}
}