using System.Collections.Generic;
using Legacy.EventLog.Model;

namespace Legacy.EventLog.View
{
    public interface ILogView : IView
    {
        string NewEntry { get; set; }
        List<LogEntry> Log { set; get; }
        string InfoStatus { get; set; }
    }
}
