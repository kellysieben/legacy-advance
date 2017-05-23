using Legacy.EventLog.Model;
using Legacy.EventLog.View;

namespace Legacy.EventLog.Presenter
{
    public class LogPresenter : PresenterBase<ILogView>, ILogPresenter<ILogView>
    {
        private readonly ILogService _service;

        public LogPresenter(ILogService service)
        {
            _service = service;
        }

        public void Init()
        {
            CheckAndLoadAllEntries();
        }

        public void NewEntry()
        {
            _service.AddNewEntry(new LogEntry {Details = View.NewEntry});
            View.NewEntry = "";
            CheckAndLoadAllEntries();
        }

        private void CheckAndLoadAllEntries()
        {
            if (View.LogCount == _service.Count) return;

            View.Log = _service.GetAllEntries();
            View.InfoStatus = "[" + _service.GetType().Name + "] > Number of Entries: " + _service.Count;
        }
    }
}