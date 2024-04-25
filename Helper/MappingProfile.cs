using AutoMapper;
using PokemanReviewApp.Dto;
using PokemanReviewApp.Models;

namespace PokemanReviewApp.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Get & Read Method In API
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<Review, ReviewDto>();
            CreateMap<Reviewer, ReviewerDto>();

            // Post & Create Method in API // Put & Update Method In API
            CreateMap<CategoryDto, Category>();
            CreateMap<CountryDto, Country>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<ReviewDto, Review>();
            CreateMap<ReviewerDto, Reviewer>();
        }
    }
}
