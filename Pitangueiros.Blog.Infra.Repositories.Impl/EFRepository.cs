using System;
using System.Data.Entity;
using System.Linq;
using Pitangueiros.Blog.Domain.Contracts.Repositories;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl
{
    public class EFRepository<T, TId> : IRepository<T, TId>
        where T : class, IEntidadeBase<TId> , new()
        where TId : IComparable<TId>, IEquatable<TId> {
        protected DbContext Context { get; }

        protected DbSet<T> Table => Context.Set<T>();

        public EFRepository(DbContext context) {
            this.Context = context;
        }

        public void Inserir(T entidade) {
            this.Context.Set<T>()
                .Add(entidade);

            this.Context.SaveChanges();
        }

        public T ObterPorId(TId id) {
            var result = from entidade in Context.Set<T>()
                         where entidade.Id.Equals(id)
                select entidade;

            return result.SingleOrDefault();

        }
    }
}
