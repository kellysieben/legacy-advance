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

        public void AddNewEntry(LogEntry newEntry)
        {
            Task.Run(() => AddNewEntryAsync(newEntry));
        }

        public List<LogEntry> GetAllEntries()
        {
            return GetAllEntriesAsync().Result;
        }

        private async Task AddNewEntryAsync(LogEntry newEntry)
        {
            await _logClient.PostAsJsonAsync($"api/Log", newEntry);
        }

        private async Task<List<LogEntry>> GetAllEntriesAsync()
        {
            List<LogEntry> all = null;
            var response = await _logClient.GetAsync($"api/Log").ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                all = await response.Content.ReadAsAsync<List<LogEntry>>();
            }

            return all;
        }

        public int Count => -1;
    }
}