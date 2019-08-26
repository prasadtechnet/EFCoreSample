using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace CAEFCoreApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EF Core Learning session");

            //case 1
            DataAccess.DataContext objContext = new BloggingContextFactory().CreateDbContext(null);

            // objContext.Database.Migrate();

            //  objContext.Users.Add(new DataAccess.Entities.User { Firstname = "jkd", Password = "123" });
            // objContext.Roles.Add(new DataAccess.Entities.Role { Name = "SalesHead" });

            objContext.UserRoles.Add(new DataAccess.Entities.UserRole {UserID=1,RoleID=1 });
            objContext.SaveChanges();

            var rls = objContext.Roles.AsNoTracking();

            Console.ReadLine();
        }

        public class BloggingContextFactory : IDesignTimeDbContextFactory<DataAccess.DataContext>
        {
            public DataAccess.DataContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DataAccess.DataContext>();
                optionsBuilder.UseSqlServer("Data Source=localhost;User id=sa;password=Mobile123;Database=DB1");

                return new DataAccess.DataContext(optionsBuilder);
            }
        }
    }
}
