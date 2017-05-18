using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace Legacy.EventLog.Infrastructure
{
    public class CoreDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<HttpClient>(new InjectionFactory(factory =>
            {
                var client = new HttpClient { BaseAddress = new Uri(WebConfigurationManager.AppSettings["RemoteServiceBaseAddress"]) };
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client;
            }));

            ((UnityConfigurationSection)ConfigurationManager.GetSection("unity")).Configure(Container);
        }
    }
}