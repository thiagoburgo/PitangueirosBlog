using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl.Mappings
{
    public class UsuarioBaseMapping<T> : EntityTypeConfiguration<T> where T:Usuario
    {
        public UsuarioBaseMapping() {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Nome).HasColumnName("Nome").IsRequired();
            this.Property(p => p.Senha).HasColumnName("Senha").IsRequired();
            this.Property(p => p.Email).HasColumnName("Email").IsRequired();
        }
    }
}
