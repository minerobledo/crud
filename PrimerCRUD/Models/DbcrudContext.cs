using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PrimerCRUD;

namespace PrimerCRUD.Models;

public partial class DbcrudContext : DbContext
{
    
    private readonly IConfiguration _configuration;
    

    public DbcrudContext(DbContextOptions<DbcrudContext> options,IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
  
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

   

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(_configuration["ConnectionString:conexion"]);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC07B7C04E4F");

            entity.ToTable("Usuario");

            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
