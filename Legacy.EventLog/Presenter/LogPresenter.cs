using Legacy.EventLog.Model;
using Legacy.EventLog.View;

namespace Legacy.EventLog.Presenter
{
    public class LogPresenter : PresenterBase<ILogView>, ILogPresenter<ILogView>
    {
        private readonly ILogView _view;
        private readonly ILogService _service;

        public LogPresenter(ILogView view, ILogService service)
        {
            _view = view;
            _service = service;
        }

        public void Init()
        {
            LoadAllEntries();
        }

        public void NewEntry()
        {
            _service.AddNewEntry(_view.NewEntry);
            _view.NewEntry = "";
            LoadAllEntries();
        }

        private void LoadAllEntries()
        {
            _view.Log = _service.GetAllEntries();
            _view.InfoStatus = "Number of Entries: " + _service.EntryCounter;
        }

    }
}