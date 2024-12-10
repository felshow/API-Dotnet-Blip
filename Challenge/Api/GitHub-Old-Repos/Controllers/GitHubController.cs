using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class GitHubController : ControllerBase
{
    private readonly IGitHubService _gitHubService;

    public GitHubController(IGitHubService gitHubService)
    {
        _gitHubService = gitHubService;
    }

    [HttpGet("oldest-repos/{username}")]
    public async Task<IActionResult> GetOldestCSharpRepositories(string username, int count = 5)
    {
        var repositories = await _gitHubService.GetOldestCSharpRepositoriesAsync(username, count);

        // Adapta a resposta para incluir o nome e a descrição
        var response = repositories.Select(repo => new
        {
            repo.Name,
            repo.Description,
            repo.CreatedAt
        });

        return Ok(response);
    }
}
