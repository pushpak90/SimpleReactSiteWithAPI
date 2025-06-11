using ReactAPI.Models;

namespace ReactAPI.Repositories.Interfaces
{
    public interface IFormRepository
    {
        Task AddFormAsync(Form form);
    }
}
