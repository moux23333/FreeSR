namespace FreeSR.Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface ISRDatabase<T> where T : class
    {
        Task Insert(T document);
        Task InsertMany(IEnumerable<T> documents);
        Task<List<T>> Find(Expression<Func<T, bool>> filter);
        Task<T> FindOne(Expression<Func<T, bool>> filter);
        Task Update(Expression<Func<T, bool>> filter, T updatedDocument);
        Task Delete(Expression<Func<T, bool>> filter);
        Task<long> Count();
        Task<T> FindMax(Expression<Func<T, object>> fieldSelector);
    }
}
