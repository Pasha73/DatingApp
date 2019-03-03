using AutoMapper;
using DatingApp.Models;
using DatingApp.Dtos;
using System.Linq;

namespace DatingApp.Helpers
{
    public class AutoMappersProfiles: Profile
    {
        public AutoMappersProfiles () {
            CreateMap<User, UserForListDto>()
                    .ForMember(dest => dest.PhotoUrl, opt => {
                        opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                    })
                    .ForMember(dest => dest.Age, opt => {
                        opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
                    });
            CreateMap<User, UserForDetailedDto>()
                    .ForMember(dest => dest.PhotoUrl, opt => {
                        opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                    })
                    .ForMember(dest => dest.Age, opt => {
                        opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
                    });
            CreateMap<Photo, PhotoForDetailedDto>(); 
        }
    }
}