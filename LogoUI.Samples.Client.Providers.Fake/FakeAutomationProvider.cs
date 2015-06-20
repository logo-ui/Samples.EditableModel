using LogoUI.Samples.Client.Builders;
using LogoUI.Samples.Client.Model.Contracts.Automation;
using LogoUI.Samples.Client.Providers.Contracts;

namespace LogoUI.Samples.Client.Providers.Fake
{
    class FakeAutomationProvider : IAutomationProvider
    {
        public IProxy GetProxy()
        {
            var builder = AutomationProviderBuilder.CreateBuilder();
            builder = builder.WithProxy("192.168.0.1");
            return builder.GetService().GetProxy();
        }
    }
}
