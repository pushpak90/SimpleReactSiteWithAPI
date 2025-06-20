using API8.Data;
using API8.Models;
using API8.Repositories.Interfaces;
using System;

namespace API8.Repositories.Implementations
{
    public class ProspectRepository : IProspectRepository
    {
        private readonly AppDbContext _context;
        public ProspectRepository(AppDbContext context) => _context = context;
        public async Task AddFormAsync(Prospect form)
        {
            await _context.TBL_Prospect.AddAsync(form);
            await _context.SaveChangesAsync();
        }

    }
}
