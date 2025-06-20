using ReactAPI.DTOs;
using ReactAPI.Models;
using AutoMapper;
using Microsoft.SqlServer.Server;

namespace ReactAPI.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<FormDTO, Form>();
            CreateMap<Form, FormDTO>();
        }
    }
}
