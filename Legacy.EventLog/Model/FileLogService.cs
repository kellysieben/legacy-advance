using System;
using System.Collections.Generic;
using System.IO;

namespace Legacy.EventLog.Model
{
    public class FileLogService : ILogService
    {
        private const string CLogFile = "c:\\logs\\jbf.log";

        public int EntryCounter
        {
            get
            {
                if (!File.Exists(CLogFile)) return 0;

                var counter = 0;
                using (var sr = File.OpenText(CLogFile))
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
            using (var sw = File.AppendText(CLogFile))
            {
                sw.WriteLine("<" + DateTime.Now + "> " + newEntry);
            }
        }

        public string[] GetAllEntries()
        {
            if (!File.Exists(CLogFile)) return new string[] {};

            var all = new List<string>();
            using (var sr = File.OpenText(CLogFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    all.Add(line);
                }
            }

            return all.ToArray();
        }
    }
}