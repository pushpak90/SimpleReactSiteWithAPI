using Microsoft.EntityFrameworkCore;
using ReactAPI.Data;
using ReactAPI.Models;
using ReactAPI.Repositories.Interfaces;

namespace ReactAPI.Repositories.Implementations
{
    public class FormRepository : IFormRepository
    {
        private readonly AppDbContext _context;
        public FormRepository(AppDbContext context) => _context = context;

        public async Task AddFormAsync(Form form)
        {
            await _context.Forms.AddAsync(form);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Form>> GetAllAsync()
        {
            return await _context.Forms.ToListAsync();
        }
    }

}
