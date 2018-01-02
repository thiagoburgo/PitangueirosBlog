using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("Server=(local);Database=BlogPitangueiros;User Id=pitangueiros;Password=pitangaebom") {
           
        }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Postagem> Postagem { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            // Mapeamento de Autor
            modelBuilder.Entity<Autor>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Autor>()
                .Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Autor>()
                .Property(p => p.Bio).HasColumnName("Bio");
            modelBuilder.Entity<Autor>()
                .Property(p => p.Nome).HasColumnName("Nome").IsRequired();
            //--------------------

            modelBuilder.Entity<Postagem>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Postagem>()
                .Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Postagem>()
                .Property(p => p.Conteudo).HasColumnName("Conteudo").IsRequired();
            modelBuilder.Entity<Postagem>()
                .Property(p => p.Titulo).HasColumnName("Titulo").IsRequired();
            modelBuilder.Entity<Postagem>()
                .Property(p => p.DataHoraAtualizacao).HasColumnName("DataHoraAtualizacao").IsRequired();
            modelBuilder.Entity<Postagem>()
                .Property(p => p.DataHoraCriacao).HasColumnName("DataHoraCriacao").IsRequired();
            modelBuilder.Entity<Postagem>()
                .HasRequired(p => p.Autor)
                .WithMany();
            //-------------------------------------------


            base.OnModelCreating(modelBuilder);
        }
    }
}
