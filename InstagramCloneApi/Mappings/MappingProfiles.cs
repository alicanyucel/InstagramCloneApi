using AutoMapper;
using InstagramCloneApi.Dtos;
using InstagramCloneApi.Models;

namespace InstagramCloneApi.Mappings
{
    public class MappingProfiles : Profile
    {

        public MappingProfiles()
        {

            CreateMap<UsersDto, User>().ReverseMap();
        }


    }
}
