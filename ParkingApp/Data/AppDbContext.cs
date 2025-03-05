using Microsoft.EntityFrameworkCore;
using ParkingApp.Models.Entities;

namespace ParkingApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define your DbSets (tables)
        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}