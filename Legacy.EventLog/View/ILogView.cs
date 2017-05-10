using System.Collections.Generic;

namespace Legacy.EventLog.View
{
    public interface ILogView : IView
    {
        string NewEntry { get; set; }
        List<string> Log { set; get; }
        string InfoStatus { get; set; }
    }
}
