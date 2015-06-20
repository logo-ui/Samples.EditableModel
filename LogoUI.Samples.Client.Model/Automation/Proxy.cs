using LogoUI.Samples.Client.Model.Contracts.Automation;

namespace LogoUI.Samples.Client.Model.Automation
{
    public class Proxy : LogoModel, IProxy
    {
        public string IpAddress { get; set; }
    }
}
