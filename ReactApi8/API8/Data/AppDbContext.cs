using API8.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace API8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Prospect> TBL_Prospect { get; set; }
    }
}
