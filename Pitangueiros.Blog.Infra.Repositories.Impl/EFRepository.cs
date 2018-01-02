using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.Blog.Domain.Contracts.Repositories;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl
{
    public class EFRepository<T, TId> : IRepository<T, TId>
        where T : class, IEntidadeBase<TId> , new()
        where TId : IComparable<TId>, IEquatable<TId> {

        private BlogDbContext blogContext;
        public EFRepository() {
            blogContext = new BlogDbContext();
        }

        public void Inserir(T entidade) {
            throw new NotImplementedException();
        }

        public T ObterPorId(TId id) {
            var result = from entidade in blogContext.Set<T>()
                         where entidade.Id.Equals(id)
                select entidade;

            return result.SingleOrDefault();

        }
    }
}
