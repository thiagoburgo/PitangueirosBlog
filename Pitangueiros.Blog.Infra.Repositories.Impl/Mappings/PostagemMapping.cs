using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl.Mappings
{
    public class PostagemMapping : EntityTypeConfiguration<Postagem>
    {
        public PostagemMapping()
        {

            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Conteudo).HasColumnName("Conteudo").IsRequired();
            this.Property(p => p.Titulo).HasColumnName("Titulo").IsRequired();
            this.Property(p => p.DataHoraAtualizacao).HasColumnName("DataHoraAtualizacao").IsRequired();
            this.Property(p => p.DataHoraCriacao).HasColumnName("DataHoraCriacao").IsRequired();
            this.HasRequired(p => p.Autor).WithMany(p => p.Postagems);

        }
    }
}
