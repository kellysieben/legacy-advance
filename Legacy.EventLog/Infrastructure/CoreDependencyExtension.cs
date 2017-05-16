using System.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace Legacy.EventLog.Infrastructure
{
    public class CoreDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            ((UnityConfigurationSection)ConfigurationManager.GetSection("unity")).Configure(Container);
        }
    }
}