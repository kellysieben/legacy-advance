using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Legacy.EventLog.Model
{
    public class FileLogService : ILogService
    {
        private readonly string _logFile = ConfigurationManager.AppSettings["LogFileLocation"];

        public void AddNewEntry(LogEntry newEntry)
        {
            if (string.IsNullOrEmpty(newEntry.Details)) return;
            using (var sw = File.AppendText(_logFile))
            {
                sw.WriteLine(DateTime.Now + "," + newEntry.Details);
            }
        }

        public List<LogEntry> GetAllEntries()
        {
            var entries = new List<LogEntry>();
            if (!File.Exists(_logFile)) return entries;

            var logFile = File.ReadAllLines(_logFile);

            var sep = new[] {','};

            entries.AddRange(from e in logFile
                select e.Split(sep)
                into s
                where s.Length >= 2
                select new LogEntry
                {
                    Timestamp = DateTime.Parse(s[0]), Details = s[1]
                });

            return entries;
        }

        public int Count => GetAllEntries().Count;
    }
}