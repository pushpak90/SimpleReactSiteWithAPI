using ReactAPI.DTOs;
using ReactAPI.Models;
using AutoMapper;

namespace ReactAPI.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<FormDTO, Form>();
        }
    }
}
