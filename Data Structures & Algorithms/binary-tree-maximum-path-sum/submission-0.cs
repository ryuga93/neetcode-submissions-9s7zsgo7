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
    public int MaxPathSum(TreeNode root) {
        var res = root.val;
        PathSum(root, ref res);
        return res;
    }

    private int PathSum(TreeNode node, ref int res)
    {
        if (node == null)
        {
            return 0;
        }

        var leftMax = Math.Max(PathSum(node.left, ref res), 0);
        var rightMax = Math.Max(PathSum(node.right, ref res), 0);

        res = Math.Max(res, node.val + leftMax + rightMax);

        return node.val + Math.Max(leftMax, rightMax);
    }
}
