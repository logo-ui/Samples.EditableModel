using Attest.Fake.Moq;
using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoFX.UI.Tests.NUnit;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;

namespace LogoUI.Samples.Client.Tests.Gui.Shared.Integration
{
    public abstract class IntegrationTestsBaseWithActivation : TestsBaseWithActivation<ExtendedSimpleIocContainer, FakeFactory, ShellViewModel, TestBootstrapper>
    {        
    }
}
