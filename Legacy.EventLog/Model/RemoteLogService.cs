using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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

        public void AddNewEntry(string newEntry)
        {
            AddNewEntryAsync(newEntry);
        }

        private async Task AddNewEntryAsync(string newEntry)
        {
            var response = await _logClient.PostAsync($"api/Log", null);
        }

        public List<string> GetAllEntries()
        {
            return GetAllEntriesAsync().Result;
        }

        private async Task<List<string>> GetAllEntriesAsync()
        {
            List<string> all = null;
            var response = await _logClient.GetAsync($"api/Log").ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                all = await response.Content.ReadAsAsync<List<string>>();
            }

            return all;
        }

    }
}