using AutoMapper;
using ReactAPI.DTOs;
using ReactAPI.Models;
using ReactAPI.Repositories.Interfaces;
using ReactAPI.Services.Interfaces;

namespace ReactAPI.Services.Implementations
{
    public class FormService : IFormService
    {
        private readonly IFormRepository _repo;
        private readonly IMapper _mapper;

        public FormService(IFormRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task SubmitFormAsync(FormDTO dto)
        {
            var form = _mapper.Map<Form>(dto);
            await _repo.AddFormAsync(form);
        }
    }
}
