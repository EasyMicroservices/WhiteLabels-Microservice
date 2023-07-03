using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.WhiteLabelsMicroservice.Database.Contexts
{
    public class WhiteLabelContext : DbContext
    {
        IDatabaseBuilder _builder;
        public WhiteLabelContext(IDatabaseBuilder builder)
        {
            _builder = builder;
        }

        public DbSet<WhiteLabelEntity> WhiteLabels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_builder != null)
                _builder.OnConfiguring(optionsBuilder);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WhiteLabelEntity>(model =>
            {
                model.HasKey(r => r.Id);
            });
        }
    }
}