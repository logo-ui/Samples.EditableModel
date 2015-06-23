using System.Linq;
using Attest.Fake.Moq;
using Attest.Tests.Specflow;
using LogoUI.Samples.Client.Builders;
using LogoUI.Samples.Client.Gui.Modularity.ViewModels;
using LogoUI.Samples.Client.Gui.Modules.Automation.ViewModels;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;
using LogoUI.Samples.Client.Tests.Gui.Shared;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace LogoUI.Samples.Client.Tests.Gui.Modules.Automation.Specifications.Steps
{
    [Binding]
    class AutomationSteps : StepsBase<FakeFactory>
    {
        [Given(@"Server returns (.*) proxy record with ip address '(.*)'")]
        public void GivenServerReturnsProxyRecordWithIpAddress(int p0, string ipAddress)
        {
            var automationProviderBuilder = ScenarioHelper.Resolve(AutomationProviderBuilder.CreateBuilder);
            automationProviderBuilder.WithProxy(ipAddress);
            RegisterBuilder(automationProviderBuilder);
        }                       

        [When(@"I access the automation screen")]
        public void WhenIAccessTheAutomationScreen()
        {
            GetAutomationRoot();
        }

        [When(@"I set proxy ip address value to '(.*)'")]
        public void WhenISetProxyIpAddressValueTo(string ipAddress)
        {
            var automationRoot = GetAutomationRoot();
            var firstProxy = automationRoot.MainViewModel.ProxiesCollection.OfType<AutomationProxyViewModel>().First();            
            firstProxy.Model.IpAddress = ipAddress;            
        }

        [When(@"I press undo proxy changes button")]
        public void WhenIPressUndoProxyChangesButton()
        {
            var automationRoot = GetAutomationRoot();
            automationRoot.MainViewModel.UndoChangesCommand.Execute(null);
        }

        [Then(@"proxy address should be '(.*)'")] 
        public void ThenProxyAddressShouldBe(string address)
        {
            var automationRoot = GetAutomationRoot();
            var actualIpAddress =
                automationRoot.MainViewModel.ProxiesCollection.OfType<AutomationProxyViewModel>()
                    .First()
                    .Model.IpAddress;
            Assert.AreEqual(address, actualIpAddress);
        }

        private static AutomationRootViewModel GetAutomationRoot()
        {
            var mainViewModel = (MainViewModel)StructureHelper.GetShellActiveItem();
            var firstModule = mainViewModel.Modules.OfType<ModuleViewModel>().First(t => t.Name == "Automation");
            return (AutomationRootViewModel)(firstModule.RootViewModel);
        }
    }
}
