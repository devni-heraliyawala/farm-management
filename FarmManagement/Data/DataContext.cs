using System;
using Microsoft.EntityFrameworkCore;

namespace FarmManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Farm> Farms { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}

