using Refit;
using Zeyt.Refit_Dad_Jokes_Api.Models;

namespace Zeyt.Refit_Dad_Jokes_Api.Services
{
    [Headers("accept: application/json")]
    public interface IJokesService
    {
        [Get("/random_joke")]
        Task<JokesResponse> GetRandomJoke();

        [Get("/random_ten")]
        Task<IEnumerable<JokesResponse>> GetRandomTenJokes();
    }
}
