using ReactAPI.DTOs;

namespace ReactAPI.Services.Interfaces
{
    public interface IFormService
    {
        Task SubmitFormAsync(FormDTO dto);
    }
}
