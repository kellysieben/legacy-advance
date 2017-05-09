using Legacy.EventLog.Model;
using Legacy.EventLog.Presenter;
using Legacy.EventLog.View;
using Microsoft.Practices.Unity;

namespace Legacy.EventLog.Infrastructure
{
    public class CoreDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<ILogService, FileLogService>();
            Container.RegisterType<ILogPresenter<ILogView>, LogPresenter>();
        }
    }
}