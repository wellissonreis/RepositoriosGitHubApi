using AutoMapper;
using ConsumirAPI.Dtos;
using ConsumirAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Octokit;
using System.Text.Json;

namespace ConsumirAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class LerRepositorioController : ControllerBase
{
    private readonly IMapper _mapper;

    public LerRepositorioController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet("{name}")]
    public async Task<IActionResult> LerRepositorioGeral(string name)
    {
        var client = new GitHubClient(new ProductHeaderValue(name));

        try
        {
            var repositories = await client.Repository.GetAllForUser(name);
            var serializ = JsonSerializer.Serialize(repositories);
            var te = Convert.ToString(serializ);
            var repos = JsonSerializer.Deserialize<List<ReposModels>>(te);

            return Ok(_mapper.Map<List<ReposDto>>(repos));
        }
        catch (Exception ex)
        {
            return NotFound($"Possívelmente o usuário descrito não existe, verifiquei a informação descrita : {ex.Message}");
        }
    }
}
