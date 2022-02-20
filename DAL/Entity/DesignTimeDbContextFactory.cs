using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SampleContext>
    {
        public SampleContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var builder = new DbContextOptionsBuilder<SampleContext>();
            //var connectionString = ""; //todo
            var connectionString = configuration.GetConnectionString("MssqlConnection");
            builder.UseSqlServer(connectionString);
            return new SampleContext(builder.Options);
        }
    }
}
