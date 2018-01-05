
using AutoMapper;
using Pitangueiros.Blog.App.Entities;
using Pitangueiros.Blog.Cross.IoC.AutoMapper;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.App.Services.Impl.Mappers
{
    public class UsuarioMapperProfile : Profile, IMapperProfile
    {
        public UsuarioMapperProfile() {
            CreateMap<Usuario, UsuarioOutputDto>();
        }
    }
}
