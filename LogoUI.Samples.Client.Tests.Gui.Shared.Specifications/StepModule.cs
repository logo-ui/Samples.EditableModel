using System.ComponentModel.Composition;
using System.Reflection;
using Solid.Practices.Modularity;

namespace LogoUI.Samples.Client.Tests.Gui.Shared.Specifications
{
    [Export(typeof(ICompositionModule))]
    class StepModule : IStepModule
    {
        public StepModule()
        {
            StepAssembly = Assembly.GetExecutingAssembly().GetName().Name;
        }

        public string StepAssembly { get; private set; }
    }
}
