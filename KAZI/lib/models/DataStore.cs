using System;
using System.Collections.Generic;

namespace KAZI.lib.models;

public class BaseDataStore
{
    public BaseDataStore()
    {
        
    }

    public bool Connect()
    {
        
    }
}
public class QueueDataStore: IDataStore<Job>
{
    
    public Job Store(Job item)
    {
        throw new NotImplementedException();
    }

    public Job Stores(params Job[] items)
    {
        throw new NotImplementedException();
    }

    public Job RemoveItem(Func<Job, bool> condition)
    {
        throw new NotImplementedException();
    }

    public Job SetNx(Job item)
    {
        throw new NotImplementedException();
    }

    public List<Job> GetAll()
    {
        throw new NotImplementedException();
    }
}


public class ListDataStore
{
    
}