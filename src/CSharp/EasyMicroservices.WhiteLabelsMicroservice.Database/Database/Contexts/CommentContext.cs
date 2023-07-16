using EasyMicroservices.CommentsMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.CommentsMicroservice.Database.Contexts
{
    public class CommentContext : DbContext
    {
        IDatabaseBuilder _builder;
        public CommentContext(IDatabaseBuilder builder)
        {
            _builder = builder;
        }

        public DbSet<CommentEntity> Comments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_builder != null)
                _builder.OnConfiguring(optionsBuilder);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CommentEntity>(model =>
            {
                model.HasKey(x => x.Id);
            });

        }
    }
}