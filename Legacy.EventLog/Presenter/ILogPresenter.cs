namespace Legacy.EventLog.Presenter
{
    public interface ILogPresenter<TView> : IPresenter<TView>
    {
        void Init();
        void NewEntry();
    }
}
