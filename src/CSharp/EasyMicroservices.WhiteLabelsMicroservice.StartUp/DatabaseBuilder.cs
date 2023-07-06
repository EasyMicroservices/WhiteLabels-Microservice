using EasyMicroservices.WhiteLabelsMicroservice.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.WhiteLabelsMicroservice
{
    public class DatabaseBuilder : IDatabaseBuilder
    {
        public void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("WhiteLabels database");
            optionsBuilder.UseSqlServer("Server=.;Database=WhiteLabels;User ID=test;Password=test1234;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
