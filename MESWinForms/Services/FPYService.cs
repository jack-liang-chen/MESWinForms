using MESWinForms.MediaTypes.In.TestResult;
using MESWinForms.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MESWinForms.Services
{
    public class FPYService
    {
        private readonly DataService _dataService;
        private readonly Logger _logger;

        public FPYService(DataService dataService, Logger logger)
        {
            _dataService = dataService;
            _logger = logger;
        }

        public async Task<FPYViewModel> GetAll()
        {
            var data = await _dataService.GetAsync<TestResultInMediaType>("nitestmonitor/v2/results?returnCount=false");
            var currentYear = DateTime.Now.Year;
            var currentMonth = DateTime.Now.Month;

            var vm = new FPYViewModel();

            for (int i = 0; i < 12; i++)
            {
                var targetMonth = currentMonth - i;
                var targetYear = currentYear;

                if (targetMonth <= 0)
                {
                    targetMonth += 12;
                    targetYear -= 1;
                }

                var targetTestResult = data.results.Where(x => x.updatedAt.Year == targetYear && x.updatedAt.Month == targetMonth);

                //var passByMonth = 0d;
                var failedByMonth = 0d;
                foreach (var item in targetTestResult)
                {
                    //passByMonth += item.statusTypeSummary.PASSED;
                    failedByMonth += item.statusTypeSummary.FAILED;
                }
                //var totalByMonth = passByMonth + failedByMonth;
                //var failedRateByMonth = totalByMonth == 0 ? 0 : failedByMonth / totalByMonth;
                vm.FPYByMonth.Add(targetMonth, failedByMonth);
            }

            return vm;
        }
    }
}
