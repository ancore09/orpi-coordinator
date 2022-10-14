namespace orpi_coordinator.Utils;

public class Helpers
{
    public static List<string> dfs(string vertex, ref Dictionary<string, List<string>> al, ref HashSet<string> visited)
    {
        List<string> res = new List<string>();

        List<string> set = al[vertex];
        foreach (var s in set)
        {
            if (!visited.Contains(s))
            {
                res.AddRange(dfs(s, ref al, ref visited));
            }
        }

        if (!visited.Contains(vertex))
        {
            visited.Add(vertex);
            res.Add(vertex);
        }

        return res;
    }
}