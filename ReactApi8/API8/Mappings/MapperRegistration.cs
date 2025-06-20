using API8.DTOs;
using API8.Models;
using AutoMapper;


namespace API8.Mappings
{
    public class MapperRegistration : Profile
    {
        public MapperRegistration()
        {
            CreateMap<RegistrationDTO, Registration>();
        }
    }
}
