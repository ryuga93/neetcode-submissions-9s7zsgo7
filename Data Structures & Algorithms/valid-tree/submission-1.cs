public class Solution {
    public bool ValidTree(int n, int[][] edges)
    {
        if (edges.Length > n - 1)
        {
            return false;
        }

        HashSet<int> visited = new HashSet<int>();
        List<List<int>> adjacents = new List<List<int>>();

        for (var i = 0; i < n; i++)
        {
            adjacents.Add(new List<int>());
        }

        foreach (var edge in edges)
        {
            adjacents[edge[0]].Add(edge[1]);
            adjacents[edge[1]].Add(edge[0]);
        }

        if (!Dfs(visited, 0, -1, adjacents))
        {
            return false;
        }
        
        return visited.Count == n;
    }

    private bool Dfs(HashSet<int> visited, int node, int parent, List<List<int>> adjacents)
    {
        if (visited.Contains(node))
        {
            return false;
        }

        visited.Add(node);
        foreach (var neighbour in adjacents[node])
        {
            if (neighbour == parent)
            {
                continue;
            }

            if (!Dfs(visited, neighbour, node, adjacents))
            {
                return false;
            }
        }

        return true;
    }
}
