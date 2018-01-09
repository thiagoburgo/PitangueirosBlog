﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl.Mappings
{
    public class UsuarioMapping : UsuarioBaseMapping<Usuario>
    {
        public UsuarioMapping() {
            ToTable("Usuario");
        }
    }
}
