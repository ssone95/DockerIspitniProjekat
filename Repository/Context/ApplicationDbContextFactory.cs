using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public static string ConnectionString { get; private set; } = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ?? "username=postgres;password=Secret123;host=localhost;port=54320;Database=DockerStore;";

        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.EnableSensitiveDataLogging(true);
            builder.UseNpgsql(ConnectionString);
            return new ApplicationDbContext(builder.Options);
        }
    }
}
