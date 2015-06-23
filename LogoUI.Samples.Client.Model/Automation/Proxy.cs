using LogoFX.UI.Model;
using LogoUI.Samples.Client.Model.Contracts.Automation;

namespace LogoUI.Samples.Client.Model.Automation
{
    public class Proxy : EditableModel<int>, IProxy
    {
        private string _ipAddress;
        public string IpAddress
        {
            get { return _ipAddress; }
            set
            {
                if (_ipAddress == value)
                {
                    return;
                }
                _ipAddress = value;
                NotifyOfPropertyChange();
            }
        }
    }
}
