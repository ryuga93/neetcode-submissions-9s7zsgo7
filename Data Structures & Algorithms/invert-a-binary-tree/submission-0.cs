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
    public TreeNode InvertTree(TreeNode root) {
        var current = root;
        if (current == null)
        {
            return null;
        }

        var left = current.left;

        current.left = current.right;
        current.right = left;

        InvertTree(current.left);
        InvertTree(current.right);

        return root;
    }
}
