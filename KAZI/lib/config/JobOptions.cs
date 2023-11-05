using Jobber.lib.enums;
using KAZI.lib.enums;

namespace KAZI.lib.config
{
    public class JobOptions
    {
        public int DelayInSeconds { get; set; } = 0;
        public bool RemoveOnComplete { get; set; } = true;
        public bool RemoveOnFailure { get; set; } = false;
        public Repeatable? Repeat { get; set; }
        public Retry? Retry { get; set; }
    }

    public class Retry
    {
        public int Attempt { get; set; } = 3;
        public Backdrop? Backdrop { get; set; }
    }

    public class Backdrop
    {
        public BackdropType BackdropType { get; set; }
        public int Every { get; set; }
        public Frequency Frequency { get; set; }
    }
    
    public class Repeatable
    {
        public int Every { get; set; }
        public Frequency Frequency { get; set; }
    }
}