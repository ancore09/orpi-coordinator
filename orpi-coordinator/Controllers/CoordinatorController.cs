using Microsoft.AspNetCore.Mvc;
using orpi_coordinator.Models;
using orpi_coordinator.Utils;

namespace orpi_coordinator.Controllers;

[ApiController]
[Route("[controller]")]
public class CoordinatorController : Controller
{

    [HttpPost]
    [Route("create-env")]
    public async Task<IActionResult> CreateEnvironment([FromBody] EnvCreateRequest request)
    {
        var deps = request.Dependencies;

        var visited = new HashSet<string>();
        List<string> res = new List<string>();
        foreach (var depsKey in deps.Keys)
        {
            res.AddRange(Helpers.dfs(depsKey, ref deps, ref visited));
        }
        return Ok(res);
    }
}