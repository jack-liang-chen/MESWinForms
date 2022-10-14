using MESWinForms.ViewModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Services
{
    public class AlarmService
    {
        private const string QUERY = "nialarm/v1/query-instances";

        private readonly DataService _dataService;
        private readonly Logger _logger;

        public AlarmService(DataService dataService, Logger logger)
        {
            _dataService = dataService;
            _logger = logger;
        }

        public async Task<List<AlarmViewModel>> GetAll() 
        {
            List<AlarmViewModel> result = new List<AlarmViewModel>();

            var data = await _dataService.GetAllAsync(QUERY);
            var count = 0;

            var maxCount = data.filterMatches.Count < 10 ? data.filterMatches.Count() : 10;
            
            for (int i = 0; i < maxCount; i++)
            {
                var item = data.filterMatches[i];
                var vm = new AlarmViewModel
                {
                    Id = ++count,
                    System = item.properties.system
                };
                var lastTransition = item.transitions.OrderBy(x => x.occurredAt).LastOrDefault();
                vm.CurrentTransitionType = lastTransition?.transitionType;
                vm.ResourceType = item.resourceType;
                vm.LastValue = lastTransition?.properties.value;

                result.Add(vm);
            }

            return result;
        }
    }
}
