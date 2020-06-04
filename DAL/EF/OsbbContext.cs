using System;
using System.Collections.Generic;
using System.Text;
using DAL.EF.Interfaces;
using DAL.Entities;
using DAL.EntitiesConfigurations;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class OsbbContext : DbContext, IOsbbContext
    {
        public OsbbContext(DbContextOptions<OsbbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder?.ApplyConfiguration(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
