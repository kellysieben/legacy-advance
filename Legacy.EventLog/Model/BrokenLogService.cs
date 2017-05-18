using System;
using System.Collections.Generic;

namespace Legacy.EventLog.Model
{
    public class BrokenLogService : ILogService
    {
        public void AddNewEntry(string newEntry)
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetAllEntries()
        {
            return new List<string>() {"<" + DateTime.Now + "> Don't even. It broke!"};
        }
    }
}