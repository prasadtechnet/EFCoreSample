using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Common.Entities;
using OrderManagement.DataInfrastructure.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.DataInfrastructure.ContextCore
{
   public class DataContext: IdentityDbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>()
                .Property(u => u.Id).HasColumnType("string");

            builder.Entity<ApplicationRole>()
                .Property(r => r.Id).HasColumnType("string");

            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserRole<string>>()
                .Property(ur => ur.UserId).HasColumnType("string");
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserRole<string>>()
                .Property(ur => ur.RoleId).HasColumnType("string");

            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserClaim<string>>()
              .Property(ur => ur.UserId).HasColumnType("string");

            //Required


            //primary Keys
            builder.Entity<Branch>()
                .HasKey(b => b.Id);

            builder.Entity<Customer>()
                .HasKey(b => b.Id);

            builder.Entity<Product>()
                .HasKey(b => b.Id);

            builder.Entity<Order>()
               .HasKey(b => b.Id);

            builder.Entity<OrderItem>()
               .HasKey(b => b.Id);

            builder.Entity<ObjectIndex>()
               .HasKey(b => b.Id);

            //FKs

            base.OnModelCreating(builder);
        }


        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<ApplicationRole> Roles { get; set; }

        public DbSet<Branch> Branch { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ObjectIndex> ObjectIndexs { get; set; }

        public void Save()
        {
            base.SaveChanges();
        }

        
    }
}
