using System.Collections.Generic;
using System.Threading.Tasks;

public interface IGitHubService
{
    Task<IEnumerable<Repository>> GetOldestCSharpRepositoriesAsync(string username, int count);
}
