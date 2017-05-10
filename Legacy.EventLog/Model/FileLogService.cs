using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Legacy.EventLog.Model
{
    public class FileLogService : ILogService
    {
        private readonly string _logFile = ConfigurationManager.AppSettings["LogFileLocation"];

        public void AddNewEntry(string newEntry)
        {
            if (string.IsNullOrEmpty(newEntry)) return;
            using (var sw = File.AppendText(_logFile))
            {
                sw.WriteLine("<" + DateTime.Now + "> " + newEntry);
            }
        }

        public List<string> GetAllEntries()
        {
            if (!File.Exists(_logFile)) return new List<string>();

            var logFile = File.ReadAllLines(_logFile);
            return new List<string>(logFile);
        }
    }
}