using System;
using System.IO;

namespace Legacy.EventLog
{
    public partial class EventLogger : System.Web.UI.Page
    {
        private const string CLogFile = "c:\\logs\\jbf.log";

        protected void Page_Load(object sender, EventArgs e)
        {
            ReadLogFile();
        }

        protected void AddLogButton_Click(object sender, EventArgs e)
        {
            AddToLogFile(NewEventTextBox.Text);
            NewEventTextBox.Text = "";
            ReadLogFile();
        }

        private void AddToLogFile(string entry)
        {
            if (string.IsNullOrEmpty(entry)) return;
            using (var sw = File.AppendText(CLogFile))
            {
                sw.WriteLine("<" + DateTime.Now + "> " + entry);
            }
        }

        private void ReadLogFile()
        {
            if (!File.Exists(CLogFile)) return;

            LoggedEventsList.Items.Clear();

            var counter = 0;

            using (var sr = File.OpenText(CLogFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    LoggedEventsList.Items.Add(line);
                    counter++;
                }
            }
            InfoStatus.Text = "Num Log Lines: " + counter;
        }
    }
}