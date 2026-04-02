public class DisjointSetUnion
{
    private int[] parent;
    private int[] size;

    public DisjointSetUnion(int n)
    {
        parent = new int[n];
        size = new int[n];

        for (var i = 0; i < n; i++)
        {
            parent[i] = i;
            size[i] = 1;
        }
    }

    private int FindParent(int node)
    {
        var current = node;
        while (current != parent[current])
        {
            parent[current] = parent[parent[current]];
            current = parent[current];
        }

        return current;
    }

    public bool Union(int nodeU, int nodeV)
    {
        var parentU = FindParent(nodeU);
        var parentV = FindParent(nodeV);

        if (parentV == parentU)
        {
            return false;
        }

        if (size[parentV] > size[parentU])
        {
            (parentU, parentV) = (parentV, parentU);
        }

        parent[parentV] = parentU;
        size[parentU] += size[parentV];

        return true;
    }
}

public class Solution {
    public int CountComponents(int n, int[][] edges)
    {
        var dsu = new DisjointSetUnion(n);

        var result = n;

        foreach (var edge in edges)
        {
            if (dsu.Union(edge[0], edge[1]))
            {
                result--;
            }
        }

        return result;
    }
}
