using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Persistence
{
    public class CarWorkshopDbContext : DbContext
    {
        //public DbSet<CarWorkshop> CarWorkshops { get; set; } class name can't be same like namespace
        public DbSet<Domain.Entities.CarWorkshop> CarWorkshops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarWorkshopDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.CarWorkshop>()
                .OwnsOne(c => c.ContactDetails); //ContactDetails is a column, no table
        }
    }
}
