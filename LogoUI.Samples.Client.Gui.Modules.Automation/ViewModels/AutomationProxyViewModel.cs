using LogoFX.UI.ViewModels;
using LogoUI.Samples.Client.Model.Contracts.Automation;

namespace LogoUI.Samples.Client.Gui.Modules.Automation.ViewModels
{
    public class AutomationProxyViewModel : ObjectViewModel<IProxy>
    {
        public AutomationProxyViewModel(IProxy model) : base(model)
        {
            
        }
    }
}