using API8.DTOs;

namespace API8.Services.Interfaces
{
    public interface IProspectService
    {
        Task SubmitFormAsync(ProspectDTO dto);
    }
}
