using API8.DTOs;
using API8.Models;
using API8.Repositories.Implementations;
using API8.Repositories.Interfaces;
using API8.Services.Interfaces;
using AutoMapper;

namespace API8.Services.Implementations
{
    public class ProspectService : IProspectService
    {
        private readonly IProspectRepository _repo;
        private readonly IMapper _mapper;


        public ProspectService(IProspectRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task SubmitFormAsync(ProspectDTO dto)
        {
            var form = _mapper.Map<Prospect>(dto);
            form.DateTime = DateTime.Now;
            await _repo.AddFormAsync(form);
        }
    }
}
