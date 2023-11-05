using System;
using Jobber.lib.enums;
using KAZI.lib.enums;

namespace KAZI.lib.config
{
    public class KaziOptions
    {
        public JobberHistory? History { get; set; }
        public JobberUISettings? UiSettings { get; set; }
        public Backend Backend { get; set; } = Backend.REDIS;
        public QueueType QueueType { get; set; } = QueueType.LIFO;
        public bool EnableLog { get; set; }
        public bool AutoConnect { get; set; } = true;
        public BackendConnection BackendConnection { get; set; }
        public JobExecutionStrategy Strategy { get; set; }
    }

    public class JobExecutionStrategy
    {
        public JobExecutionMode Mode { get; set; } = JobExecutionMode.SEQUENTIALLY;
        public int? BatchSize { get; set; }
    }
    
    public class JobberHistory
    {
        public bool CaptureHistory { get; set; } = false;
        public Backend Location { get; set; }
    }
    public class JobberUISettings
    {
        public bool Enable { get; set; } = false;
        public int Port { get; set; } = 57699;
        public string HostAddress { get; set; } = "127.0.0.1";
    }

    public class BackendConnection
    {
        public string Host { get; set; } = String.Empty;
        public int? Port { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Url { get; set; }
    }
}