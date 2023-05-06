using eGym.Domain;
using Microsoft.EntityFrameworkCore;

namespace eGym.DAL;

public partial class DataBaseContext
{
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>().HasData(
            new Account() { AccountId = 1, Username = "user", FirstName = "user", Password = "test", BirthDate = DateTime.Now, LastName = "user", Email = "user@test.com", Gender = 1, Role = 2 }
            );

        modelBuilder.Entity<Employee>().HasData(
            new Employee() { EmployeeId = 1, Username = "desktop", FirstName = "desktop", Password = "test", BirthDate = DateTime.Now, LastName = "desktop", Email = "desktop@test.com", Gender = 1, Role = 0 },
            new Employee() { EmployeeId = 2, Username = "mobile", FirstName = "mobile", Password = "test", BirthDate = DateTime.Now, LastName = "mobile", Email = "mobile@test.com", Gender = 1, Role = 0 },
            new Employee() { EmployeeId = 3, Username = "employee", FirstName = "employee", Password = "test", BirthDate = DateTime.Now, LastName = "employee", Email = "employee@test.com", Gender = 1, Role = 1 }
            );
    }
}

