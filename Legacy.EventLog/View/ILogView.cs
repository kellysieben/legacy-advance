namespace Legacy.EventLog.View
{
    public interface ILogView
    {
        string NewEntry { get; set; }
        string[] Log { set; }
        string InfoStatus { get; set; }
    }
}
