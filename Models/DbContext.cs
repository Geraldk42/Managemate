using Microsoft.EntityFrameworkCore;
using Managemate.Models;

namespace Managemate.Models;

public class ManageMateDBConetxt : DbContext
{
    public ManageMateDBConetxt(DbContextOptions<ManageMateDBConetxt> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Task> Tasks { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<User>()
            .HasMany(c => c.Tasks)
            .WithOne(a => a.User)
            .HasForeignKey(a => a.CreatedBy)
            .OnDelete(DeleteBehavior.Cascade);
    }

}
