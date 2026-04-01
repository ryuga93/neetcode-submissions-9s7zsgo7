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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        var list = new List<string>();
        Dfs(root, list);

        return String.Join(",", list);
    }

    private void Dfs(TreeNode node, List<string> list)
    {
        if (node == null)
        {
            list.Add("N");
            return;
        }

        list.Add(node.val.ToString());
        Dfs(node.left, list);
        Dfs(node.right, list);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        var nodes = data.Split(",");
        var i = 0;
        return DeserializeDfs(nodes, ref i);
    }

    private TreeNode DeserializeDfs(string[] nodes, ref int i)
    {
        if (nodes[i] == "N")
        {
            i++;
            return null;
        }

        var node = new TreeNode(Int32.Parse(nodes[i]));
        i++;
        node.left = DeserializeDfs(nodes, ref i);
        node.right = DeserializeDfs(nodes, ref i);

        return node;
    }
}
