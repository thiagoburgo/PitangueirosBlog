using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl.Mappings
{
    public class ModeradorMapping : UsuarioBaseMapping<Moderador>
    {
        public ModeradorMapping() {
            this.ToTable("Moderador");
            this.HasMany(p => p.PostagensModeradas)
                .WithOptional(p => p.Moderador);
        }
    }
}
