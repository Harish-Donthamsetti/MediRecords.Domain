using System;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

namespace MediRecords.Domain.Entities;

public class MediRecordsDbContext : DbContext
{
    public MediRecordsDbContext() { }
    public MediRecordsDbContext(DbContextOptions<MediRecordsDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        if (!optionsBuilder.IsConfigured) {
            
            Env.Load();
            // 1) Prefer environment variable during library-only development
            var cs = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");

            if (string.IsNullOrWhiteSpace(cs))
            {
                throw new InvalidOperationException(
                "Connection string not found. " +
                "Set ConnectionStrings__DefaultConnection in environment variables or .env");
            }

            optionsBuilder.UseSqlServer(cs);
        }

    }
}
