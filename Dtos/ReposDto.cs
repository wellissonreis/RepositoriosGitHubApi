using System.Text.Json.Serialization;

namespace ConsumirAPI.Dtos;

public class ReposDto
{
    public string? NomeCompleto { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }
}
