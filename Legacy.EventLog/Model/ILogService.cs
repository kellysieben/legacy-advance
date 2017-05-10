using System.Collections.Generic;

namespace Legacy.EventLog.Model
{
    public interface ILogService
    {
        void AddNewEntry(string newEntry);
        List<string> GetAllEntries();
        int EntryCounter { get; }
    }
}
