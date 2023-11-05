using System;

namespace KAZI.lib.models;

public class JobEventArgs: EventArgs
{
    public Job Data { get; set; }

    public JobEventArgs(Job job)
    {
        Data = job;
    }
}