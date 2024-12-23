using Microsoft.EntityFrameworkCore;
using Signa.Models;

namespace Signa.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}