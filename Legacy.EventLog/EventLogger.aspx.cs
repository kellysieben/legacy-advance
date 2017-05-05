using System;
using System.IO;
using Legacy.EventLog.Model;
using Legacy.EventLog.Presenter;
using Legacy.EventLog.View;

namespace Legacy.EventLog
{
    public partial class EventLogger : System.Web.UI.Page, ILogView
    {
        private LogPresenter _presenter;

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
                if (value == null) return;

                LoggedEventsList.Items.Clear();
                foreach (var s in value)
                {
                    LoggedEventsList.Items.Add(s);
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new LogPresenter(this, new FileLogService());
            _presenter.Init();
        }

        protected void AddLogButton_Click(object sender, EventArgs e)
        {
            _presenter.NewEntry();
        }
    }
}