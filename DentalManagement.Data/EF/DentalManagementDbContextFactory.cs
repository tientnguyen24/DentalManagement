using DentalManagement.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DentalManagement.Data.EF
{
    class DentalManagementDbContextFactory : IDesignTimeDbContextFactory<DentalManagementDbContext>
    {
        public DentalManagementDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DentalManagementDb");

            var optionsBuilder = new DbContextOptionsBuilder<DentalManagementDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new DentalManagementDbContext(optionsBuilder.Options);
        }
    }
}
