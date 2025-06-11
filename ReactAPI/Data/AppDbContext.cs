using Microsoft.EntityFrameworkCore;
using ReactAPI.Models;
using System.Collections.Generic;

namespace ReactAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Form> Forms { get; set; }
    }
}
