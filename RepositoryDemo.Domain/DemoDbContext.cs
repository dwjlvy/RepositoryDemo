using Microsoft.EntityFrameworkCore;
using RepositoryDemo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDemo.Domain
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("t_account");
                entity.HasKey(e => e.F_Id);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}

