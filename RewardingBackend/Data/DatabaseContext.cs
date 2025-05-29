using Microsoft.EntityFrameworkCore;
using RewardingBackend.Models;
using System;

namespace RewardingBackend.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Reward> Rewards { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees");
                entity.HasKey(b => b.EmployeeId);
            });

            modelBuilder.Entity<Reward>(entity =>
            {
                entity.ToTable("Rewards");
                entity.HasKey(r => r.RewardId);
                entity.HasOne<Employee>()
                    .WithMany()
                    .HasForeignKey(r => r.EmployeeId);
            });
        }
    }
}