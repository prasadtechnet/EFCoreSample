using CAEFCoreApp1.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CAEFCoreApp1.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptionsBuilder opt):base(opt.Options)
        {
            opt.UseSqlServer("Data Source=localhost;User id=sa;password=Mobile123;Database=DB1");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserID);

            modelBuilder.Entity<User>()
              .Property(u => u.CreatedOn)
              .HasComputedColumnSql("GETDATE()");


            modelBuilder.Entity<User>()
              .Property(u => u.UserID)
               .UseSqlServerIdentityColumn();

            //Role
            modelBuilder.Entity<Role>()
              .HasKey(r => r.RoleID);

            modelBuilder.Entity<Role>()
              .Property(u => u.CreatedOn)
              .HasComputedColumnSql("GETDATE()");

            modelBuilder.Entity<Role>()
             .Property(u => u.RoleID)
             .UseSqlServerIdentityColumn();

            //User role
            modelBuilder.Entity<UserRole>()
                .HasKey(u => new {u.UserID,u.RoleID });
            modelBuilder.Entity<UserRole>()
                .HasOne(u => u.User)
                .WithMany(u => u.UserRole)
                .HasForeignKey(u => u.UserID);

            modelBuilder.Entity<UserRole>()
               .HasOne(u => u.Role)
               .WithMany(u => u.UserRole)
               .HasForeignKey(r => r.RoleID);

            //User Claim
            modelBuilder.Entity<UserClaim>()
               .HasKey(u => u.UserClaimID);

            modelBuilder.Entity<UserClaim>()
                .HasOne(u => u.User)
                .WithMany(u => u.UserClaim)
                .HasForeignKey(u => u.UserID);

            modelBuilder.Entity<UserClaim>()
                .Property(u => u.UserClaimID)
                .UseSqlServerIdentityColumn();


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }
    }
}
