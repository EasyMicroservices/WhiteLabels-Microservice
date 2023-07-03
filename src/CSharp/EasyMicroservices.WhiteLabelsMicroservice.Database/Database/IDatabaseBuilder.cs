using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.WhiteLabelsMicroservice.Database
{
    public interface IDatabaseBuilder
    {
        void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
    }
}
