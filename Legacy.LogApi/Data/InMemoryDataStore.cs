using System.Collections.Generic;

namespace Legacy.LogApi.Data
{
    public class InMemoryDataStore
    {
        private static readonly List<string> All = new List<string>();

        public void Add(string entry)
        {
            All.Add(entry);
        }

        public List<string> Get() => All;
    }
}