using System;

namespace Pitangueiros.Blog.Domain.Entities {
    public interface IEntidadeBase<TId> 
        where TId:IComparable<TId>, IEquatable<TId>
    {
        TId Id { get; set; }
    }
}