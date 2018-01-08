using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using Pitangueiros.Blog.Domain.Entities;
using Pitangueiros.Blog.Infra.Repositories.Impl.Mappings;

namespace Pitangueiros.Blog.Infra.Repositories.Impl
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("Server=(local);Database=BlogPitangueiros;User Id=pitangueiros;Password=pitangaebom") {
           
        }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Postagem> Postagem { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            
            
            modelBuilder.Configurations.Add(new AutorMapping());
            modelBuilder.Configurations.Add(new PostagemMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
