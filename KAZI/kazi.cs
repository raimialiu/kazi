using System;
using KAZI.lib.config;
using KAZI.lib.helpers;
using KAZI.lib.config;
using KAZI.lib.helpers;
using KAZI.lib.models;

namespace KAZI
{
    public delegate void JobCallbacks<T>(Job<T> data);
    public class kazi
    {
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