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
    int preId = 0;
    int inId = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return Build(preorder, inorder, int.MaxValue);
    }

    private TreeNode Build(int[] preorder, int[] inorder, int limit)
    {
        if (preId >= preorder.Length)
        {
            return null;
        }

        if (inorder[inId] == limit)
        {
            inId++;
            return null;
        }

        var root = new TreeNode(preorder[preId]);
        preId++;
        root.left = Build(preorder, inorder, root.val);
        root.right = Build(preorder, inorder, limit);

        return root;
    }
}
