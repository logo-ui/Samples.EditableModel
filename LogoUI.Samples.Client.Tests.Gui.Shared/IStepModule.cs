using Solid.Practices.Modularity;

namespace LogoUI.Samples.Client.Tests.Gui.Shared
{
    public interface IStepModule : ICompositionModule
    {
        string StepAssembly { get; }
    }
}
