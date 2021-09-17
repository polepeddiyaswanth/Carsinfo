using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DBContexts
{
    public class MyDBContexts:DbContext
    {
        public DbSet<Carsinfo> Carsinfos { get; set; }

        public MyDBContexts(DbContextOptions<MyDBContexts> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carsinfo>().ToTable("Carsinfos");

            modelBuilder.Entity<Carsinfo>().HasKey(u => u.CarModelNo).HasName("PK_Carsinfos");
            
            //Configure indexes 
            modelBuilder.Entity<Carsinfo>().HasIndex(p => p.CarModelNo).IsUnique().HasDatabaseName("Idx_CarModelNo");
            modelBuilder.Entity<Carsinfo>().HasIndex(p => p.CarCompany).IsUnique().HasDatabaseName("Idx_CarCompany");
            modelBuilder.Entity<Carsinfo>().HasIndex(p => p.CarName).IsUnique().HasDatabaseName("Idx_CarName");
            modelBuilder.Entity<Carsinfo>().HasIndex(p => p.CarColor).IsUnique().HasDatabaseName("Idx_CarColor");
            modelBuilder.Entity<Carsinfo>().HasIndex(p => p.CarFuelType).IsUnique().HasDatabaseName("Idx_CarFuelType");
            modelBuilder.Entity<Carsinfo>().HasIndex(p => p.CarTransmission).IsUnique().HasDatabaseName("Idx_CarTransmission");
            modelBuilder.Entity<Carsinfo>().HasIndex(p => p.CarBodyType).IsUnique().HasDatabaseName("Idx_CarBodyType");

            // Configure columns
            modelBuilder.Entity<Carsinfo>
       ().Property(u => u.CarModelNo).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Carsinfo>
       ().Property(u => u.CarCompany).HasColumnType("nvarchar(50)").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Carsinfo>
       ().Property(u => u.CarName).HasColumnType("nvarchar(50)").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Carsinfo>
       ().Property(u => u.CarColor).HasColumnType("nvarchar(50)").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Carsinfo>
       ().Property(u => u.CarFuelType).HasColumnType("nvarchar(50)").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Carsinfo>
       ().Property(u => u.CarTransmission).HasColumnType("nvarchar(50)").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Carsinfo>
       ().Property(u => u.CarBodyType).HasColumnType("nvarchar(50)").UseMySqlIdentityColumn().IsRequired();

            
        }
    }
}  



        
