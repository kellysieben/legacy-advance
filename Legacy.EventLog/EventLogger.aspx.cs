using System;
using System.Collections.Generic;
using System.Linq;
using Legacy.EventLog.Model;
using Legacy.EventLog.Presenter;
using Legacy.EventLog.View;

namespace Legacy.EventLog
{
    public partial class EventLogger : ViewBase<ILogPresenter<ILogView>, ILogView>, ILogView
    {
        public EventLogger()
        {
        }

        protected override void PageLoad()
        {
            if (!IsPostBack)
            {
                Presenter.Init();
            }
        }

        public string NewEntry
        {
            get { return NewEventTextBox.Text; }
            set { NewEventTextBox.Text = value; }
        }

        public string InfoStatus
        {
            get { return InfoStatusLabel.Text; }
            set { InfoStatusLabel.Text = value; }
        }

        public int LogCount => LoggedEventsList.Items.Count;

        public List<LogEntry> Log
        {
            set
            {
                LoggedEventsList.Items.Clear();
                foreach (var l in value)
                {
                    LoggedEventsList.Items.Add("<" + l.Timestamp + "> " + l.Details);
                }
            }
            get
            {
                return (from object s in LoggedEventsList.Items select new LogEntry {Details = s as string}).ToList();
            }
        }

        protected void AddLogButton_Click(object sender, EventArgs e)
        {
            Presenter.NewEntry();
        }
    }
}