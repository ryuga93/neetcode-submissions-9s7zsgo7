public class Solution {
    private Dictionary<int, List<int>> prerequisiteMap = new Dictionary<int, List<int>>();
    private HashSet<int> visited = new HashSet<int>();
    
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        for (var i = 0; i < numCourses; i++)
        {
            prerequisiteMap[i] = new List<int>();
        }

        foreach (var prerequisite in prerequisites)
        {
            prerequisiteMap[prerequisite[0]].Add(prerequisite[1]);
        }

        for (var i = 0; i < numCourses; i++)
        {
            if (!Dfs(i))
            {
                return false;
            }
        }

        return true;
    }

    private bool Dfs(int course)
    {
        if (visited.Contains(course))
        {
            return false;
        }

        if (prerequisiteMap[course].Count == 0)
        {
            return true;
        }

        visited.Add(course);

        foreach (var prereq in prerequisiteMap[course])
        {
            if (!Dfs(prereq))
            {
                return false;
            }
        }

        visited.Remove(course);
        prerequisiteMap[course].Clear();

        return true;
    }
}
