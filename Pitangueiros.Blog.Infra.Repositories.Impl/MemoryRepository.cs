using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.Blog.Domain.Contracts.Repositories;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl
{
    public class MemoryRepository<T, TId> 
        : IRepository<T, TId> 
            where T : IEntidadeBase<TId> 
            where TId : IComparable<TId>, IEquatable<TId>
    {

        protected static readonly List<T> minhasEntidades = new List<T>();

        public void Inserir(T entidade)
        {
            if (entidade == null) {
                throw new ArgumentNullException(nameof(entidade));
            }

            minhasEntidades.Add(entidade);
        }

        public T ObterPorId(TId id)
        {
            var query = from entidade in minhasEntidades
                where entidade.Id.Equals(id) 
                select entidade;

            return query.SingleOrDefault();
        }
    }
}
