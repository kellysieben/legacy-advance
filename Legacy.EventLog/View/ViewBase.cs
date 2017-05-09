using System;
using System.Web.UI;
using Legacy.EventLog.Presenter;
using Microsoft.Practices.Unity;

namespace Legacy.EventLog.View
{
    public abstract class ViewBase<TPresenter, TView> : Page
        where TPresenter : IPresenter<TView>
        where TView : class, IView
    {
        [Dependency]
        public TPresenter Presenter { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Presenter.Bind(sender as TView);
            PageLoad();
        }

        protected abstract void PageLoad();
    }
}