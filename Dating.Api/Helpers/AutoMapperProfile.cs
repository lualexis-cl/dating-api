using System;
using System.Linq;
using AutoMapper;
using Dating.Api.Dtos;
using Dating.Api.Models;

namespace Dating.Api.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDetailListDto>()
                .ForMember(destination => destination.PhotoUrl, option =>
                    option.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(destination => destination.Age, option =>
                    option.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserDetailDto>()
                .ForMember(destination => destination.PhotoUrl, option =>
                    option.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(destination => destination.Age, option =>
                    option.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDetailDto>();
        }
    }
}
