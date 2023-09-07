using Microsoft.EntityFrameworkCore;
using ProjekatRestoran.Models;

namespace ProjekatRestoran.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Meni> Jela { get; set; }
    }
}
