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
            var all = _service.GetAllEntries();
            View.Log = all;
            View.InfoStatus = "Number of Entries: " + all.Count;
        }
    }
}