using System;
using KAZI.lib.config;
using KAZI.lib.helpers;
using KAZI.lib.config;
using KAZI.lib.helpers;
using KAZI.lib.models;

namespace KAZI
{
    public delegate void JobEventHandler(object source, JobEventArgs arg);
    public class kazi
    {
        public event JobEventHandler JobCompleted;
        public event JobEventHandler JobFailed;
        public event JobEventHandler JobStarted;
        public event JobEventHandler JobStalled;
        public event JobEventHandler JobTerminated;
        public event JobEventHandler JobRunning;
        
        
        
        private KaziOptions _options;
        public kazi()
        {
            _options = JobberHelper.DefaultOptions();
        }

        public kazi(KaziOptions options)
        {
            _options = options;
        }

        public void AddAndProcess<T>(string name, JobOptions options, Action<T> callback)
        {
            
        }
    }
}