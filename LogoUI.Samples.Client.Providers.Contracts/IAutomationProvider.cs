using LogoUI.Samples.Client.Model.Contracts.Automation;

namespace LogoUI.Samples.Client.Providers.Contracts
{
    public interface IAutomationProvider
    {
        IProxy GetProxy();
    }
}
