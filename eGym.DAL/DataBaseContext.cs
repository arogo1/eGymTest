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

    public DbSet<Account> Accounts { get; set; }
}

