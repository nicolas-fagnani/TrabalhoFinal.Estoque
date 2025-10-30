﻿namespace Estoque.Domain.Base;

public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
{
    void CleanChageTracker();
    void AttachObject(object obj);
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(object id);
    IList<TEntity> Select(IList<string>? includes = null);
    TEntity Select(object id, IList<string>? includes = null);
}