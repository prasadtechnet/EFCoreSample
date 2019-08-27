﻿// <auto-generated />
using System;
using CAEFCoreApp1.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CAEFCoreApp1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190827044705_UserCliamAdd")]
    partial class UserCliamAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CAEFCoreApp1.DataAccess.Entities.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<string>("Name");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CAEFCoreApp1.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<string>("Firstname");

                    b.Property<string>("Password");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CAEFCoreApp1.DataAccess.Entities.UserClaim", b =>
                {
                    b.Property<int>("UserClaimID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserID");

                    b.HasKey("UserClaimID");

                    b.HasIndex("UserID");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("CAEFCoreApp1.DataAccess.Entities.UserRole", b =>
                {
                    b.Property<int>("UserID");

                    b.Property<int>("RoleID");

                    b.HasKey("UserID", "RoleID");

                    b.HasIndex("RoleID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("CAEFCoreApp1.DataAccess.Entities.UserClaim", b =>
                {
                    b.HasOne("CAEFCoreApp1.DataAccess.Entities.User", "User")
                        .WithMany("UserClaim")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAEFCoreApp1.DataAccess.Entities.UserRole", b =>
                {
                    b.HasOne("CAEFCoreApp1.DataAccess.Entities.Role", "Role")
                        .WithMany("UserRole")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CAEFCoreApp1.DataAccess.Entities.User", "User")
                        .WithMany("UserRole")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
