using AssetManagement.Dto;
using AssetManagement.Models;
using AutoMapper;

namespace AssetManagement.WebApi.Helpers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<AssetDetailDto, AssetDetail>().ReverseMap();
            CreateMap<AssetDto, Asset>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<IconDto, Icon>().ReverseMap();
        }
    }
}
