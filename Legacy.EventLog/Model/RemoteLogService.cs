using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Legacy.EventLog.Model
{
    public class RemoteLogService : ILogService
    {
        private readonly HttpClient _logClient;

        public RemoteLogService(HttpClient logClient)
        {
            _logClient = logClient;
        }

        public int Count => GetCountAsync();

        public void AddNewEntry(LogEntry newEntry)
        {
            Task.Run(() => AddNewEntryAsync(newEntry));
        }

        public List<LogEntry> GetAllEntries()
        {
            return GetAllEntriesAsync();
        }

        private void AddNewEntryAsync(LogEntry newEntry)
        {
             _logClient.PostAsJsonAsync($"api/Log", newEntry);
        }

        private List<LogEntry> GetAllEntriesAsync()
        {
            List<LogEntry> all = null;
            var response = _logClient.GetAsync($"api/Log").Result;

            if (response.IsSuccessStatusCode)
            {
                all = response.Content.ReadAsAsync<List<LogEntry>>().Result;
            }

            return all;
        }

        private int GetCountAsync()
        {
            var count = -1;
            var response = _logClient.GetAsync($"api/Log/Count").Result;

            if (response.IsSuccessStatusCode)
            {
                count = response.Content.ReadAsAsync<int>().Result;
            }

            return count;
        }
    }
}