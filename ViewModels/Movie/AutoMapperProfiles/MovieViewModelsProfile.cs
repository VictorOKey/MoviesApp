using AutoMapper;
using MoviesApp.Services.Dto;
using MoviesApp.ViewModels.Movie;

namespace MoviesApp.ViewModels.Movie.AutoMapperProfiles
{
    public class MovieViewModelsProfile:Profile
    {
        public MovieViewModelsProfile()
        {
            CreateMap<MovieDto, InputMovieViewModel>().ReverseMap();
            CreateMap<MovieDto, DeleteMovieViewModel>();
            CreateMap<MovieDto, EditMovieViewModel>().ReverseMap();
            CreateMap<MovieDto, MovieViewModel>();
        }
    }
}