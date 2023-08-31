using AutoMapper;
using ConsumirAPI.Dtos;
using ConsumirAPI.Models;

namespace ConsumirAPI.Mappins;

public class ReposMapper : Profile
{
    public ReposMapper()
    {
        CreateMap<ReposModels, ReposDto>();
    }
}
