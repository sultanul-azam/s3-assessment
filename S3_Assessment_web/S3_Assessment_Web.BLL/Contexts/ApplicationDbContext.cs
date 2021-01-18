using Microsoft.EntityFrameworkCore;
using S3_Assessment_Web.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace S3_Assessment_Web.BLL.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public ApplicationDbContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }       

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_migrationAssemblyName));
            }
            base.OnConfiguring(dbContextOptionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Reading>()                    
                   .HasOne(b => b.Building)
                   .WithMany(br => br.BuildingReadings)
                   .HasForeignKey(fk => fk.BuildingId);

            builder.Entity<Reading>()                 
                   .HasOne(o => o.Objects)
                   .WithMany(or => or.ObjectsReadings)
                   .HasForeignKey(fk => fk.ObjectId);

            builder.Entity<Reading>()                 
                   .HasOne(df => df.DataField)
                   .WithMany(dfr => dfr.DataFieldReadings)
                   .HasForeignKey(fk => fk.DataFieldId);            

            base.OnModelCreating(builder);
            
        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Objects> Objects { get; set; }
        public DbSet<DataField> DataFields { get; set; }
        public DbSet<Reading> Readings { get; set; }
    }
}
