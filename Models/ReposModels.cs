using System.Text.Json.Serialization;

namespace ConsumirAPI.Models;

public class ReposModels
{
    [JsonPropertyName("FullName")]
    public string? NomeCompleto { get; set; }

    [JsonPropertyName("Name")]
    public string? Nome { get; set; }

    [JsonPropertyName("Description")]
    public string? Descricao { get; set; }

}
