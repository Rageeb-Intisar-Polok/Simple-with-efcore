using AdminDBHandler.Models.User;
using AdminDBHandler.Models.User.User_Types;
using Microsoft.EntityFrameworkCore;

namespace AdminDBHandler.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Officials> Officials { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Students> Students { get; set; }
    }
}
