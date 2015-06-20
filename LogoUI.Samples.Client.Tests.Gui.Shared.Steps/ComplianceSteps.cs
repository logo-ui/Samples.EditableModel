using Attest.Fake.Moq;
using Attest.Tests.Specflow;
using LogoUI.Samples.Client.Builders;
using TechTalk.SpecFlow;

namespace LogoUI.Samples.Client.Tests.Gui.Shared.Steps
{
    [Binding]
    class ComplianceSteps : StepsBase<FakeFactory>
    {
        [Given(@"Server returns any number of compliance records")]
        public void GivenServerReturnsComplianceRecordsOfCount()
        {
            RegisterBuilder(ComplianceProviderBuilder.CreateBuilder());
        }
    }
}
