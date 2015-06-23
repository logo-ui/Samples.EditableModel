using LogoFX.UI.Model.Contracts;

namespace LogoUI.Samples.Client.Model.Contracts.Automation
{
    public interface IProxy : IModel, IEditableModel
    {
        string IpAddress { get; set; }
    }
}
