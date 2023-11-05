using System;
using System.Collections.Generic;
using Jobber.lib.enums;
using KAZI.lib.config;
using KAZI.lib.enums;

namespace KAZI.lib.models
{
    public class Job
    {
        public string Id { get; set; }
        public string EventName { get; set; }
        public object Data {get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public DateTime? LastFailedTime { get; set; }
        public JobStatus Status { get; set; }
        public List<JobHistory> Histories { get; set; }
        public JobOptions Options { get; set; }
    }

    public class JobHistory
    {
        public JobStatus Status { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public DateTime? FailedTime { get; set; }
        public Backend BackendUsed { get; set; }
        public JobOptions Options { get; set; }
        public string MethodName { get; set; }
        public string ClassCalled { get; set; }
        public string? Namespace { get; set; }
    }
    
    
}