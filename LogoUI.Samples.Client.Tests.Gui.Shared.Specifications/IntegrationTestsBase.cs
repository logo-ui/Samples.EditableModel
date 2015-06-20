using Attest.Fake.Moq;
using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoFX.UI.Tests.Specflow;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;

namespace LogoUI.Samples.Client.Tests.Gui.Shared.Specifications
{
    public abstract class IntegrationTestsBase : TestsBase<ExtendedSimpleIocContainer, FakeFactory, ShellViewModel, SpecBootstrapper>
    {
    }
}