﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl.Mappings
{
    public class AutorMapping : UsuarioBaseMapping<Autor>
    {
        public AutorMapping() {

            this.ToTable("Autor");
            this.Property(p => p.Bio).HasColumnName("Bio");
         }
    }
}
