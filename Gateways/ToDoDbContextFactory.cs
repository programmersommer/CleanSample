
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Gateways
{
    class ToDoDbContextFactory : IDesignTimeDbContextFactory<ToDoContext>
    {
        public ToDoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ToDoContext>();
            // those options are used only by EF for migrations
            // there is currently no way to get connection string from config
            optionsBuilder.UseSqlite("DataSource=D:\\ArchitectureAndSecurity\\CleanSample\\todo.db");

            return new ToDoContext(optionsBuilder.Options);
        }
    }
}
