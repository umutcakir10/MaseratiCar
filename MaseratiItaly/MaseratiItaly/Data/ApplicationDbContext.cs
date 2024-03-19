using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MaseratiItaly.Models;

namespace MaseratiItaly.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MaseratiItaly.Models.Brands> Brands { get; set; } = default!;
        public DbSet<MaseratiItaly.Models.Cars> Cars { get; set; } = default!;
    }
}
