using API8.DTOs;
using API8.Repositories.Interfaces;
using API8.Services.Interfaces;
using AutoMapper;

namespace API8.Services.Implementations
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationRepository _repo;
        private readonly IMapper _mapper;


        public RegistrationService(IRegistrationRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task SubmitRegFormAsync(RegistrationDTO dto)
        {

            

            //var form = _mapper.Map<Prospect>(dto);
            //form.DateTime = DateTime.Now;
            //await _repo.AddFormAsync(form);
        }

    }
}
