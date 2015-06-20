using Attest.Tests.Specflow;
using Caliburn.Micro;
using TechTalk.SpecFlow;

namespace LogoUI.Samples.Client.Tests.Gui.Shared.Steps
{
    [Binding]
    class GeneralSteps
    {
        [When(@"I open the application")]
        public void WhenIOpenTheApplication()
        {
            ScenarioHelper.CreateRootObject();
            StructureHelper.SetRootObject(ScenarioHelper.RootObject);
            ScreenExtensions.TryActivate(ScenarioHelper.RootObject);
        }
    }
}
