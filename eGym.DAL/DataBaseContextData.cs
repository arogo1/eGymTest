using eGym.Domain;
using Microsoft.EntityFrameworkCore;

namespace eGym.DAL;

public partial class DataBaseContext
{
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>().HasData(
            new Account() { AccountId = 1, Username = "user", FirstName = "user", Password = "test", BirthDate = DateTime.Now, LastName = "user", Gender = 1, Role = 2 }
            );

        modelBuilder.Entity<Employee>().HasData(
            new Account() { AccountId = 1, Username = "desktop", FirstName = "desktop", Password = "test", BirthDate = DateTime.Now, LastName = "desktop", Gender = 1, Role = 0 },
            new Account() { AccountId = 1, Username = "mobile", FirstName = "mobile", Password = "test", BirthDate = DateTime.Now, LastName = "mobile", Gender = 1, Role = 0 },
            new Account() { AccountId = 1, Username = "employee", FirstName = "employee", Password = "test", BirthDate = DateTime.Now, LastName = "employee", Gender = 1, Role = 1 }
            );
    }
}

