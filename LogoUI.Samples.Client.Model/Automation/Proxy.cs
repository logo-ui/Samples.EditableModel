using LogoFX.UI.Model;
using LogoUI.Samples.Client.Model.Contracts.Automation;

namespace LogoUI.Samples.Client.Model.Automation
{
    public class Proxy : EditableModel<int>, IProxy
    {
        public string IpAddress { get; set; }
    }
}
