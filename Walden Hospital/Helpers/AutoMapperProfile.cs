using AutoMapper;
using WaldenHospital.API.Models;

namespace WaldenHospital.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AbstractUserModelDTO, AbstractUserModel>();
            CreateMap<AbstractUserModel, AbstractUserModelDTO>();
        }
    }
}