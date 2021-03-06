﻿namespace Legacy.EventLog.Presenter
{
    public class PresenterBase<TView> : IPresenter<TView>
    {
        public TView View { get; set; }

        public virtual void Bind(TView view)
        {
            View = view;
        }
    }
}