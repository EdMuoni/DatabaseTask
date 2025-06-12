using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Reflection;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContextFactory : IDesignTimeDbContextFactory<DatabaseTaskDbContext>
    {
        public DatabaseTaskDbContext CreateDbContext(string[] args)
        {
            // *** SEE ON ÜLIOLULINE: ASENDA SEE OMA TEGELIKU ABSOLUUTSE TEAGA! ***
            // Näide: @"C:\Users\TeieKasutaja\Source\Repos\MinuEttevotteApp\DatabaseTask"
            var absoluteStartupProjectPath = @"C:\Users\Jazztime\Desktop\TARge24\Andmebaasisüsteemide alused\Kontrolltöö\DatabaseTask\DatabaseTask"; // <--- MUUDA SEE OMA ARVUTI TEGELEKSE TEGELIKU TEGA!

            Console.WriteLine($"DEBUG: Attempting to load appsettings.json from ABSOLUTE path: {absoluteStartupProjectPath}");

            if (!Directory.Exists(absoluteStartupProjectPath))
            {
                throw new InvalidOperationException($"The specified absolute path '{absoluteStartupProjectPath}' does not exist. Please verify the path.");
            }

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(absoluteStartupProjectPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true, reloadOnChange: true)
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException(
                    "Connection string 'DefaultConnection' not found in appsettings.json. " +
                    "Ensure 'appsettings.json' is present at the specified absolute path. " +
                    $"Attempted absolute path: {absoluteStartupProjectPath}");
            }

            var builder = new DbContextOptionsBuilder<DatabaseTaskDbContext>();
            builder.UseSqlServer(connectionString,
                b => b.MigrationsAssembly("DatabaseTask.Data"));

            return new DatabaseTaskDbContext(builder.Options);
        }
    }
}