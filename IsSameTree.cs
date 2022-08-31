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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        
        // Default
        if (p == null && q == null)
        {
            return true;
        }
        
        if (p != null && q != null)
        {
            //Console.WriteLine("P: " + p.val + ", Q: " + q.val);
        
            if (p.left != null && q.left != null)
            {
                if(IsSameTree(p.left, q.left) == false)
                {
                    return false;
                }
            }
            else if (p.left != null ^ q.left != null)
            {
                //Console.WriteLine("Not Symmetric");
                return false;
            }

            if (p.right != null && q.right != null)
            {
                if(IsSameTree(p.right, q.right) == false)
                {
                    return false;
                }
            }
            else if (p.right != null ^ q.right != null)
            {
                //Console.WriteLine("Not Symmetric");
                return false;   
            }

            if (p.val != q.val)
            {
                //Console.WriteLine("Not Equal");
                return false;
            }   
            
            return true;
        }
        
        return false;
        
    }
}