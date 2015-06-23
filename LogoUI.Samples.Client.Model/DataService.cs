using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogoUI.Samples.Client.Model.Contracts;
using LogoUI.Samples.Client.Model.Contracts.Automation;
using LogoUI.Samples.Client.Model.Contracts.Compliance;
using LogoUI.Samples.Client.Providers.Contracts;
using Solid.Practices.Scheduling;

namespace LogoUI.Samples.Client.Model
{
    public class DataService : IDataService
    {
        private readonly IComplianceProvider _complianceProvider;
        private readonly IAutomationProvider _automationProvider;
        private readonly TaskFactory _taskFactory = TaskFactoryFactory.CreateTaskFactory();

        public DataService(IComplianceProvider complianceProvider, IAutomationProvider automationProvider)
        {
            _complianceProvider = complianceProvider;
            _automationProvider = automationProvider;
        }

        public Task<IEnumerable<IComplianceRecord>> GetComplianceRecordsAsync(IComplianceRecordsFilter filter)
        {
            return
                _taskFactory.StartNew(
                    () =>
                        (IEnumerable<IComplianceRecord>)
                            _complianceProvider.GetComplianceRecords(filter.StartTime, filter.EndTime).ToArray());
        }

        public Task<IEnumerable<IProxy>> GetProxiesAsync()
        {
            return _taskFactory.StartNew(() =>
                Enumerable.Repeat(_automationProvider.GetProxy(), 1));
        }
    }
}
