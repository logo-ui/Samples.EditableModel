using Attest.Fake.Builders;
using LogoUI.Samples.Client.Model.Automation;
using LogoUI.Samples.Client.Model.Contracts.Automation;
using LogoUI.Samples.Client.Providers.Contracts;

namespace LogoUI.Samples.Client.Builders
{
    public class AutomationProviderBuilder : FakeBuilderBase<IAutomationProvider>
    {
        private IProxy _proxy;

        private AutomationProviderBuilder() : base(FakeFactoryFactory.CreateFakeFactory())
        {
        }

        public static AutomationProviderBuilder CreateBuilder()
        {
            return new AutomationProviderBuilder();
        }

        public AutomationProviderBuilder WithProxy(string ipAddress)
        {
            _proxy = new Proxy
            {
                IpAddress = ipAddress
            };
            return this;
        }

        protected override void SetupFake()
        {
            FakeService.SetupWithResult(t => t.GetProxy(), _proxy);
        }
    }
}
