using API8.Models;

namespace API8.Repositories.Interfaces
{
    public interface IRegistrationRepository
    {
        Task AddempFormAsync(Registration form);

    }
}
