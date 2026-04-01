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
    public int KthSmallest(TreeNode root, int k) {
        int[] temp = new int[2];
        temp[0] = k;
        FindSmallest(root, temp);
        return temp[1];
    }

    private void FindSmallest(TreeNode node, int[] temp)
    {
        if (node == null)
        {
            return;
        }

        FindSmallest(node.left, temp);
        temp[0]--;

        if (temp[0] == 0)
        {
            temp[1] = node.val;
            return;
        }

        FindSmallest(node.right, temp);
    }
}
