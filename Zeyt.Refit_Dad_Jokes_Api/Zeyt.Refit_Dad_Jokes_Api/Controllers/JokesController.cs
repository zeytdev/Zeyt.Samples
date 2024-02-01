using Microsoft.AspNetCore.Mvc;
using Zeyt.Refit_Dad_Jokes_Api.Models;
using Zeyt.Refit_Dad_Jokes_Api.Services;

namespace Zeyt.Refit_Dad_Jokes_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        private readonly IJokesService _jokesService;

        public JokesController(IJokesService jokesService)
        {
            _jokesService = jokesService;
        }

        [HttpGet]
        public async Task<JokesResponse> RandomJoke()
        {
            return await _jokesService.GetRandomJoke();
        }

        [HttpGet]
        public async Task<IEnumerable<JokesResponse>> RandomTenJokes()
        {
            return await _jokesService.GetRandomTenJokes();
        }
    }
}
