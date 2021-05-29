using Microsoft.EntityFrameworkCore;

namespace ComponentsLibrary
{
    public class PrescriptionSystemDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=PrescriptionSystemDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().Property(e => e.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Item>().Property(e => e.Zombie).HasDefaultValue(false);
            modelBuilder.Entity<Item>().Property(e => e.TimeStamp).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
        }

        //Command on Package Manager Console => Add-Migration 
    }
}