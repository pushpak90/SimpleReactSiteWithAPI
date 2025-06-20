using API8.Models;

namespace API8.Repositories.Interfaces
{
    public interface IProspectRepository
    {
        Task AddFormAsync(Prospect form);
    }
}
