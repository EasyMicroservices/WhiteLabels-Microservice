using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.CommentsMicroservice.Database
{
    public interface IDatabaseBuilder
    {
        void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
    }
}
