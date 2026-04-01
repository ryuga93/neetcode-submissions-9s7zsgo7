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
        if (subRoot == null)
        {
            return true;
        }
        
        if (root == null)
        {
            return false;
        }

        if (FindSubtree(root, subRoot))
        {
            return true;
        }

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool FindSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null && subRoot == null)
        {
            return true;
        }

        if (root != null && subRoot != null && root.val == subRoot.val)
        {
            return FindSubtree(root.left, subRoot.left) && FindSubtree(root.right, subRoot.right);
        }

        return false;
    }

}
