namespace Legacy.EventLog.Presenter
{
    public interface IPresenter<TView>
    {
        TView View { get; }

        void Bind(TView view);
    }
}
