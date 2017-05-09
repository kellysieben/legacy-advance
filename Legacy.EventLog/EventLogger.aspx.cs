using System;
using System.Linq;
using Legacy.EventLog.Presenter;
using Legacy.EventLog.View;

namespace Legacy.EventLog
{
    public partial class EventLogger : ViewBase<ILogPresenter<ILogView>, ILogView>, ILogView
    {
        protected override void PageLoad()
        {
            Presenter.Init();
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

        public string[] Log
        {
            set
            {
                LoggedEventsList.Items.Clear();
                foreach (var s in value)
                {
                    LoggedEventsList.Items.Add(s);
                }
            }
            get { return LoggedEventsList.Items.Cast<string>().ToArray(); }
        }

        protected void AddLogButton_Click(object sender, EventArgs e)
        {
            Presenter.NewEntry();
        }
    }
}