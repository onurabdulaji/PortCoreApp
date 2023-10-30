using AutoMapper;
using DTOLayer.DTOS.AdminDTOs;
using EntityLayer.Models;

namespace PortCoreApp.Map.Mapping
{
    public class MapManagers : Profile
    {
        public MapManagers()
        {
            CreateMap<SignUpVM, AppUser>();
            CreateMap<SignInVM, AppUser>();

        }
    }
}
