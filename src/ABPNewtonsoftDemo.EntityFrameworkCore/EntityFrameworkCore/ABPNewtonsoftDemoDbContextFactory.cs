using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ABPNewtonsoftDemo.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ABPNewtonsoftDemoDbContextFactory : IDesignTimeDbContextFactory<ABPNewtonsoftDemoDbContext>
{
    public ABPNewtonsoftDemoDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        ABPNewtonsoftDemoEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<ABPNewtonsoftDemoDbContext>()
            .UseMySQL(configuration.GetConnectionString("Default"));
        
        return new ABPNewtonsoftDemoDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ABPNewtonsoftDemo.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
