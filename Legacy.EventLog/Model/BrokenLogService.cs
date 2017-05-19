using System;
using System.Collections.Generic;

namespace Legacy.EventLog.Model
{
    public class BrokenLogService : ILogService
    {
        public void AddNewEntry(LogEntry newEntry)
        {
            throw new NotImplementedException();
        }

        public List<LogEntry> GetAllEntries()
        {
            return new List<LogEntry>()
            {
                new LogEntry {Details = "Don't even. It broke!", Timestamp = DateTime.Now }
            };
        }

        public int Count => 0;
    }
}