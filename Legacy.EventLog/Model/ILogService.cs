namespace Legacy.EventLog.Model
{
    public interface ILogService
    {
        void AddNewEntry(string newEntry);
        string[] GetAllEntries();
        int EntryCounter { get; }
    }
}
