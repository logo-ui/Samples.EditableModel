using Caliburn.Micro;
using LogoFX.Practices.IoC;
using LogoFX.UI.Navigation;
using LogoUI.Samples.Client.Gui.Shared.ViewModels;

namespace LogoUI.Samples.Client.Gui.Modules.Automation.ViewModels
{
    [Singleton]
    [NavigationViewModel(ConductorType = typeof(IMainViewModel), IsSingleton = true)]
    public sealed class AutomationRootViewModel : Screen, INavigationViewModel
    {
        public AutomationRootViewModel(AutomationMainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void OnNavigated(NavigationDirection direction, object argument)
        {
            
        }

        public AutomationMainViewModel MainViewModel { get; private set; }
    }
}