namespace Legacy.EventLog.View
{
    public interface ILogView : IView
    {
        string NewEntry { get; set; }
        string[] Log { set; get; }
        string InfoStatus { get; set; }
    }
}
