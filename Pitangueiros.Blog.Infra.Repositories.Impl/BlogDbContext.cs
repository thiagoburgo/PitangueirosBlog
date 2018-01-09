using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Pitangueiros.Blog.Domain.Entities;
using Pitangueiros.Blog.Infra.Repositories.Impl.Mappings;

namespace Pitangueiros.Blog.Infra.Repositories.Impl
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("ConnBlogPitangueiros") {
            //Desabilita a criação automatica da base de dados
            //nesse caso já temos uma base criada
            Database.SetInitializer<BlogDbContext>(null);
        }

        //public DbSet<Autor> Autores { get; set; }
        //public DbSet<Postagem> Postagem { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            
            
            modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new AutorMapping());
            modelBuilder.Configurations.Add(new ModeradorMapping());
            modelBuilder.Configurations.Add(new PostagemMapping());
            this.Database.Log = cmd => {
                Debug.WriteLine(cmd);
            };
            base.OnModelCreating(modelBuilder);
        }
    }
}
