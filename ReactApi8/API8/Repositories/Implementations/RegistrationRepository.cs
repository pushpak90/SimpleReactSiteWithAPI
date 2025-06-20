using API8.Data;
using API8.Models;
using API8.Repositories.Interfaces;

namespace API8.Repositories.Implementations
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly AppDbContext _context;
        public RegistrationRepository(AppDbContext context) => _context = context;
        public async Task AddempFormAsync(Registration form)
        {
            await _context.TBL_Employee.AddAsync(form);
            await _context.SaveChangesAsync();
        }
    }
}
