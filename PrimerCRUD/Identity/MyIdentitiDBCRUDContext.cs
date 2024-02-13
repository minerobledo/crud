using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrimerCRUD.Models;

namespace PrimerCRUD.Identity
{
    public partial class MyIdentitiDBCRUDContext : IdentityDbContext<MyUsruario,MyRol,String>
    {
        
        public MyIdentitiDBCRUDContext(DbContextOptions<MyIdentitiDBCRUDContext> options) 
            :  base(options)
        {
        }

        

        public virtual DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
}

