using System.Collections.Generic;

namespace Legacy.EventLog.Model
{
    public class RemoteLogService : ILogService
    {
        public void AddNewEntry(string newEntry)
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetAllEntries()
        {
            return new List<string>() {"<1/1/1970> Nothing to see here"};
        }
    }
}