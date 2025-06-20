
using API8.DTOs;
using API8.Models;
using AutoMapper;

namespace API8.Mappings
{
    public class MapperProspect : Profile
    {
        public MapperProspect()
        {
            CreateMap<ProspectDTO, Prospect>();

        }
    }
}
