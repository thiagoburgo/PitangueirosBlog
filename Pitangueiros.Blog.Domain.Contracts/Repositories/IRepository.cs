using System;
using System.Collections.Generic;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Domain.Contracts.Repositories
{
    public interface IRepository<T, TId> 
        where T: IEntidadeBase<TId> 
        where TId : IComparable<TId>, IEquatable<TId>
    {
        void Inserir(T entidade);

        T ObterPorId(TId id);
    }
}
