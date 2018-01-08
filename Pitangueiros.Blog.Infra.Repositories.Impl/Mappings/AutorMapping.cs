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
    public class AutorMapping : EntityTypeConfiguration<Autor>
    {
        public AutorMapping() {

            this.ToTable("Autor");
            
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Bio).HasColumnName("Bio");
            this.Property(p => p.Nome).HasColumnName("Nome").IsRequired();
            this.Property(p => p.Bio).HasColumnName("Bio");

            

        }
    }
}
