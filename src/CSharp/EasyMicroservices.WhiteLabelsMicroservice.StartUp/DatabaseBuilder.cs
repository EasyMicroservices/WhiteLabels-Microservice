using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EasyMicroservices.WhiteLabelsMicroservice
{
    public class DatabaseBuilder : IEntityFrameworkCoreDatabaseBuilder
    {
        public DatabaseBuilder(IConfiguration config)
        {
            _config = config;
        }

        readonly IConfiguration _config;

        public void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Storage database");
            //optionsBuilder.UseSqlServer(_config.GetConnectionString("local"));
        }
    }
}
