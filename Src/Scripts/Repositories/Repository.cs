using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Game.Scripts.Data;

namespace Game.Scripts.Repositories;

public abstract class Repository<T> : IRepository<T> where T : IHasIdentifier
{
    protected abstract List<T> Items { get; set; }
    
    public Action<T> OnAdd { get; set; }
    public Action<T> OnRemove { get; set; }
    
    public void Add(T item)
    {
        Items.Add(item);
        OnAdd?.Invoke(item);
    }

    public T GetById(string id) => Items.Find(x => x.Identifier == id);

    public void RemoveById(string id)
    {
        var item = Items.Find(x => x.Identifier == id);
        Items.Remove(item);
        OnRemove?.Invoke(item);
    }

    public IEnumerable<T> GetItems() => Items;

    public IQueryable<T> Query(Expression<Func<T, bool>> predicate) => Items.AsQueryable().Where(predicate);
    public IEnumerable<T> Query(string id) => Items.Where(x => x.Identifier == id);
}