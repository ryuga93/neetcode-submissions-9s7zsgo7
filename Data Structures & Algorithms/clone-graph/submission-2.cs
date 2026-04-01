/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
   Dictionary<int, Node> store = new Dictionary<int, Node>();

    public Node CloneGraph(Node node)
    {
        if (node == null)
        {
            return null;
        }

        if (store.ContainsKey(node.val))
        {
            return store[node.val];
        }

        var cloneNode = new Node(node.val);
        store.Add(node.val, cloneNode);
        foreach (var n in node.neighbors)
        {
            cloneNode.neighbors.Add(CloneGraph(n));
        }

        return cloneNode;
    }
}
