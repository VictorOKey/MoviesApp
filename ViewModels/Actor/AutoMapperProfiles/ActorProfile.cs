using MoviesApp.Models;
using AutoMapper;
using MoviesApp.Services.Dto;
using MoviesApp.ViewModels.Movie;

namespace MoviesApp.ViewModels.Actor.AutoMapperProfiles
{
    public class ActorProfile: Profile
    {
        public ActorProfile()
        {
            CreateMap<ActorDto, InputActorViewModel>().ReverseMap();
            CreateMap<ActorDto, DeleteActorViewModel>();
            CreateMap<ActorDto, EditActorViewModel>().ReverseMap();
            CreateMap<ActorDto, ActorViewModel>();
        }
    }
}