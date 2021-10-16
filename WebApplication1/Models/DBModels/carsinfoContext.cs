using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models.DBModels
{
    public partial class carsinfoContext : DbContext
    {
        public carsinfoContext()
        {
        }

        public carsinfoContext(DbContextOptions<carsinfoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user id=root;database=carsinfo;password=YASH5yash#", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.19-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_bin");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.CarModelNo)
                    .HasName("PRIMARY");

                entity.ToTable("cars");

                entity.Property(e => e.BootSpace)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CarBodyType)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CarColor)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CarCompany)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CarFuelType)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CarName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CarTransmission)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.EngineCc)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("EngineCC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
