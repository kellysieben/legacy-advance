using System;

namespace Legacy.EventLog.Model
{
    public class LogEntry
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Details { get; set; }
    }
}