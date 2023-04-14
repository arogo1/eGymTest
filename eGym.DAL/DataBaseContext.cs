using System.Collections.Generic;
using eGym.Domain;
using Microsoft.EntityFrameworkCore;

namespace eGym.DAL;

public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options)
    : base(options)
    {
    }

    public DbSet<Account> Account { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Diet> Diet { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Reservation> Reservation { get; set; }
    public DbSet<Training> Training { get; set; }
    public DbSet<Feedback> Feedback { get; set; }
}

