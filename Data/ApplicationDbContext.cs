using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjekatNapredniWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatNapredniWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options){ }
        public virtual DbSet<Proizvod> Proizvod { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-6QVG512;Database=Shop;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proizvod>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cena)
                    .IsRequired();
                    

                entity.Property(e => e.Izdavac)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Zanr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Platforma)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DatumIzlaska).HasColumnType("date");

                entity.Property(e => e.Slika)
                    .IsRequired()
                    .HasMaxLength(50);

            });
            base.OnModelCreating(modelBuilder);
        }

    }
}
