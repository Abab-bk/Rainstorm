using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Game.Scripts.Data;

namespace Game.Scripts.Repositories;

public interface IRepository<T>
{
    public Action<T> OnAdd { get; set; }
    public Action<T> OnRemove { get; set; }
    public void Add(T item);
    
    public T GetById(string id);
    public void RemoveById(string id);
    public IEnumerable<T> GetItems();
    public IQueryable<T> Query(Expression<Func<T, bool>> predicate);
    public IEnumerable<T> Query(string id);
}