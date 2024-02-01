﻿using EasyMicroservices.Cores.Relational.EntityFrameworkCore;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EasyMicroservices.WhiteLabelsMicroservice.Database.Contexts
{
    public class WhiteLabelContext : RelationalCoreContext
    {
        public WhiteLabelContext(IEntityFrameworkCoreDatabaseBuilder builder) : base(builder)
        {
        }

        public DbSet<WhiteLabelEntity> WhiteLabels { get; set; }
        public DbSet<ContextTableEntity> ContextTables { get; set; }
        public DbSet<MicroserviceEntity> Microservices { get; set; }
        public DbSet<MicroserviceContextTableEntity> MicroserviceContextTables { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WhiteLabelEntity>(model =>
            {
                model.HasKey(x => x.Id);

                model.HasOne(x => x.Parent)
                .WithMany(x => x.Children)
                .HasForeignKey(x => x.ParentId);
            });

            modelBuilder.Entity<ContextTableEntity>(model =>
            {
                model.HasKey(x => x.Id);
                model.HasIndex(x => new { x.ContextName, x.TableName }).IsUnique();

                model.HasIndex(x => x.TableName);
                model.HasIndex(x => x.ContextName);
            });

            modelBuilder.Entity<MicroserviceEntity>(model =>
            {
                model.HasKey(x => x.Id);
                model.HasIndex(x => new { x.Name, x.InstanceIndex }).IsUnique();
                model.HasIndex(x => x.Name);
            });

            modelBuilder.Entity<MicroserviceContextTableEntity>(model =>
            {
                model.HasKey(x => new { x.MicroserviceId, x.ContextTableId });

                model.HasOne(x => x.Microservice)
                .WithMany(x => x.MicroserviceContextTables)
                .HasForeignKey(x => x.MicroserviceId);

                model.HasOne(x => x.ContextTable)
                .WithMany(x => x.MicroserviceContextTables)
                .HasForeignKey(x => x.ContextTableId);
            });

            modelBuilder.Entity<MicroserviceEntity>().HasData(
                new MicroserviceEntity()
                {
                    Id = 1,
                    Name = "TemplateGenerator",
                    InstanceIndex = 1,
                },
                new MicroserviceEntity()
                {
                    Id = 2,
                    Name = "Email",
                    InstanceIndex = 1,
                },
                new MicroserviceEntity()
                {
                    Id = 3,
                    Name = "Storage",
                    InstanceIndex = 1,
                });
            modelBuilder.Entity<ContextTableEntity>().HasData(
                new ContextTableEntity()
                {
                    Id = 1,
                    ContextName = "TemplateGeneratorContext",
                    TableName = "Forms",
                },
                new ContextTableEntity()
                {
                    Id = 2,
                    ContextName = "TemplateGeneratorContext",
                    TableName = "FormDetails",
                },
                new ContextTableEntity()
                {
                    Id = 3,
                    ContextName = "TemplateGeneratorContext",
                    TableName = "FormFills",
                },
                new ContextTableEntity()
                {
                    Id = 4,
                    ContextName = "TemplateGeneratorContext",
                    TableName = "FormItems",
                },
                new ContextTableEntity()
                {
                    Id = 5,
                    ContextName = "TemplateGeneratorContext",
                    TableName = "FormItemValues",
                },
                new ContextTableEntity()
                {
                    Id = 6,
                    ContextName = "TemplateGeneratorContext",
                    TableName = "ItemTypes",
                });

            modelBuilder.Entity<MicroserviceContextTableEntity>().HasData(
                new MicroserviceContextTableEntity()
                {
                    ContextTableId = 1,
                    MicroserviceId = 1,
                },
                new MicroserviceContextTableEntity()
                {
                    ContextTableId = 2,
                    MicroserviceId = 1,
                },
                new MicroserviceContextTableEntity()
                {
                    ContextTableId = 3,
                    MicroserviceId = 1,
                },
                new MicroserviceContextTableEntity()
                {
                    ContextTableId = 4,
                    MicroserviceId = 1,
                },
                new MicroserviceContextTableEntity()
                {
                    ContextTableId = 5,
                    MicroserviceId = 1,
                },
                new MicroserviceContextTableEntity()
                {
                    ContextTableId = 6,
                    MicroserviceId = 1,
                });
            modelBuilder.Entity<WhiteLabelEntity>().HasData(
                new WhiteLabelEntity()
                {
                    Id = 1,
                    Name = "ProjectName",
                    Key = Guid.NewGuid(),
                },
                new WhiteLabelEntity()
                {
                    Id = 2,
                    ParentId = 1,
                    Name = "TenantName",
                    Key = Guid.Parse("df0f728f-4545-480c-8f0f-3de063280e98"),
                });
        }
    }
}