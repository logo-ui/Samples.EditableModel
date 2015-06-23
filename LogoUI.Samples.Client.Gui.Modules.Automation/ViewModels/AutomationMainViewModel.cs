using System.Linq;
using System.Windows.Input;
using Caliburn.Micro;
using LogoFX.UI.Commanding;
using LogoFX.UI.ViewModels;
using LogoUI.Samples.Client.Model.Contracts;
using LogoUI.Samples.Client.Model.Contracts.Automation;

namespace LogoUI.Samples.Client.Gui.Modules.Automation.ViewModels
{
    public class AutomationMainViewModel : PropertyChangedBase
    {
        private readonly IDataService _dataService;

        public AutomationMainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            Update();
        }

        private WrappingCollection _proxiesCollection;
        public WrappingCollection ProxiesCollection
        {
            get { return _proxiesCollection ?? (_proxiesCollection = CreateProxiesCollection()); }
        }

        private ActionCommand _undoChangesCommand;
        public ICommand UndoChangesCommand
        {
            get
            {
                return _undoChangesCommand ??
                       (_undoChangesCommand =
                           ActionCommand.When(() => true)
                               .Do(() => ProxiesCollection.OfType<AutomationProxyViewModel>().First().Model.Undo()));
            }
        }

        private WrappingCollection CreateProxiesCollection()
        {
            var wc = new WrappingCollection {FactoryMethod = o => new AutomationProxyViewModel((IProxy) o)};
            return wc;
        }

        private async void Update()
        {
            var proxies = (await _dataService.GetProxiesAsync()).ToArray();
            //TODO: understand why have to call this explicitly
            foreach (var proxy in proxies)
            {
                proxy.MakeDirty();
            }
            ProxiesCollection.AddSource(proxies);
        }
    }
}
