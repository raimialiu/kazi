using KAZI.lib.config;
using KAZI.lib.enums;
using KAZI.lib.config;
using KAZI.lib.enums;

namespace KAZI.lib.helpers
{
    public class JobberHelper
    {
        public static KaziOptions DefaultOptions()
        {
            return new KaziOptions()
            {
                BackendConnection = new BackendConnection()
                {
                    Port = 6379,
                    Host = "127.0.0.1"
                },
                QueueType =QueueType.LIFO,
                Backend = Backend.REDIS,
                AutoConnect = true,
                Strategy = new JobExecutionStrategy()
                {
                    Mode = JobExecutionMode.SEQUENTIALLY
                }
            };
        }
    }
}