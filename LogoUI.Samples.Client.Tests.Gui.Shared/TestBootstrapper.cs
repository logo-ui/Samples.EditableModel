using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoUI.Samples.Client.Gui.Shell;

namespace LogoUI.Samples.Client.Tests.Gui.Shared
{
    public class TestBootstrapper : BootstrapperBase
    {        
        public TestBootstrapper(ExtendedSimpleIocContainer iocContainer) : base(iocContainer,useApplication:false)
        {
        }
    }
}
