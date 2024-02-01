using System.Text.Json.Serialization;

namespace Zeyt.Refit_Dad_Jokes_Api.Models
{
    public class JokesResponse
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("setup")]
        public string? Setup { get; set; }

        [JsonPropertyName("punchline")]
        public string? Punchline { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }
    }
}