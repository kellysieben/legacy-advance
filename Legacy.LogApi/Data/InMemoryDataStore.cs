using System.Collections.Generic;

namespace Legacy.LogApi.Data
{
    public static class InMemoryDataStore
    {
        private static readonly List<string> All = new List<string>();

        public static void Add(string entry)
        {
            All.Add(entry);
        }

        public static List<string> Get() => All;

        public static void Clear() => All.Clear();
    }
}