using LogoUI.Samples.Client.Model.Contracts;

namespace LogoUI.Samples.Client.Tests.Gui.Fake
{
    public class FakeIdentityProvider : IIdentityProvider
    {
        public string Name { get; set; }
    }
}
