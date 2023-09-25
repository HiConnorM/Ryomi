using Microsoft.EntityFrameworkCore;
using Ryomi;
public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    // ... other DbSets for other tables will come here later ...

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Your Azure SQL Connection String Here");
    }
}
