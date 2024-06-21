using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PublicerenWeb.Entities;

public partial class PrulariaComContext : DbContext
{
    //public PrulariaComContext()
    //{
    //}

    public PrulariaComContext(DbContextOptions<PrulariaComContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actiecode> Actiecodes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actiecode>(entity =>
        {
            entity.HasKey(e => e.ActiecodeId).HasName("PRIMARY");

            entity.ToTable("actiecodes");

            entity.Property(e => e.ActiecodeId).HasColumnName("actiecodeId");
            entity.Property(e => e.GeldigTotDatum)
                .HasColumnType("date")
                .HasColumnName("geldigTotDatum");
            entity.Property(e => e.GeldigVanDatum)
                .HasColumnType("date")
                .HasColumnName("geldigVanDatum");
            entity.Property(e => e.IsEenmalig).HasColumnName("isEenmalig");
            entity.Property(e => e.Naam)
                .HasMaxLength(45)
                .HasColumnName("naam");
        });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
