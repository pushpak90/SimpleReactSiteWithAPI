using API8.DTOs;

namespace API8.Services.Interfaces
{
    public interface IRegistrationService
    {
        Task SubmitRegFormAsync(RegistrationDTO dto);
    }
}
