﻿namespace NetGraphQL.DataAccess.Repositories.Interfaces;

public interface IGenericRepository<T> where T : class
{
    IQueryable<T> Find(Expression<Func<T, bool>>? filter, bool tracking = true);

    Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>>? filter, bool tracking = true);

    Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>>? filter, bool tracking = true);

    Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>>? filter = null, string includeProperties = "");

    Task<T> GetByIdAsync(int id);

    Task<IEnumerable<T>> GetAllAsync();

    Task<T> AddAsync(T entity);

    Task<T> UpdateAsync(T entity);

    Task SaveChangeAsync();


    Task DeleteAsync(T entity);
}