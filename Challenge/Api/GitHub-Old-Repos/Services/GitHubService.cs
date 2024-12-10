using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class GitHubService : IGitHubService
{
    private const string GitHubApiUrl = "https://api.github.com/users/{0}/repos";

    public async Task<IEnumerable<Repository>> GetOldestCSharpRepositoriesAsync(string username, int count)
    {
        var client = new RestClient();
        var request = new RestRequest(string.Format(GitHubApiUrl, username), Method.Get);

        // Adiciona os parâmetros de consulta
        //Obs: o count necessita obter o valor 6 para retornar os 5 repositorios, devido a paginação do Github.
        request.AddQueryParameter("sort", "created");
        request.AddQueryParameter("direction", "asc");
        request.AddQueryParameter("per_page", count.ToString());
        request.AddQueryParameter("page", "1");

        Console.WriteLine(request);

        var response = await client.ExecuteAsync(request);

        Console.WriteLine(response.Content);

        if (response.IsSuccessful)
        {
            var repositories = JsonConvert.DeserializeObject<List<Repository>>(response.Content);
            return repositories.Where(r => r.Language == "C#");
        }



        return Enumerable.Empty<Repository>();
    }
}





