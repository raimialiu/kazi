namespace KAZI.lib.models
{
    public class Job<T>
    {
        public string Id { get; set; }
        public T Data {get; set; }
    }
}