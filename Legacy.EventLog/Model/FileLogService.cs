using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Legacy.EventLog.Model
{
    public class FileLogService : ILogService
    {
        //private const string CLogFile = "c:\\logs\\jbf.log";
        private readonly string _logFile = ConfigurationManager.AppSettings["LogFileLocation"];

        public int EntryCounter
        {
            get
            {
                if (!File.Exists(_logFile)) return 0;

                var counter = 0;
                using (var sr = File.OpenText(_logFile))
                {
                    while (sr.ReadLine() != null)
                    {
                        counter++;
                    }
                }
                return counter;
            }
        }

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