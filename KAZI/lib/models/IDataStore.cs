using System;
using System.Collections.Generic;

namespace KAZI.lib.models;

public interface IDataStore<T> where T: class
{
    public T Store(T item);
    public T Stores(params T[] items);
    public T RemoveItem(Func<T, bool> condition);
    public T SetNx(T item);
    public List<T> GetAll();
}