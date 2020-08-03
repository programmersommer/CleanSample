using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Gateways
{
    class ToDoDbContextFactory : IDesignTimeDbContextFactory<ToDoContext>
    {
        public ToDoContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("ToDoDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<ToDoContext>();

            optionsBuilder.UseSqlite(connectionString);

            return new ToDoContext(optionsBuilder.Options);
        }
    }
}
