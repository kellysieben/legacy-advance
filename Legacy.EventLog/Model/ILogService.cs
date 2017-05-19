using System.Collections.Generic;

namespace Legacy.EventLog.Model
{
    public interface ILogService
    {
        void AddNewEntry(LogEntry newEntry);
        List<LogEntry> GetAllEntries();
        int Count { get; }
    }
}
