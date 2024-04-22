using AutoMapper;
using PokemanReviewApp.Dto;
using PokemanReviewApp.Models;

namespace PokemanReviewApp.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
