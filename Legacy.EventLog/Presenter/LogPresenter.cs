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
            LoadAllEntries();
        }

        public void NewEntry()
        {
            _service.AddNewEntry(View.NewEntry);
            View.NewEntry = "";
            LoadAllEntries();
        }

        private void LoadAllEntries()
        {
            View.Log = _service.GetAllEntries();
            View.InfoStatus = "Number of Entries: " + _service.EntryCounter;
        }

    }
}