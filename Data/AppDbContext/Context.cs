using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.AppDbContext
{
    public class Context : DbContext
    {

        public Context(DbContextOptions options) : base(options)
        {
        }


        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).HasMaxLength(150).IsRequired();
                entity.Property(e => e.Password).HasMaxLength(150).IsRequired();
                entity.Property(e => e.Email).HasMaxLength(150).IsRequired();
                entity.Property(e => e.IsDeleted).IsRequired().HasDefaultValue(false);
                entity.Property(e => e.Gender).IsRequired();
                entity.HasIndex(e => e.Email).IsUnique();
            });

        }

    }
}
