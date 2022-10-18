using MESWinForms.MediaTypes.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Services
{
    public class SystemInfoService
    {
        private readonly DataService _dataService;

        public SystemInfoService(DataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<int> GetSystemsCountAsync()
        {
            var data = await _dataService.GetAsync<SystemsSummaryInMediaType>("nisysmgmt/v1/get-systems-summary");
            return data.connectedCount;
        }

        public async Task<AssetsInMediaType> GetAssetsAsync()
        { 
            return await _dataService.GetAsync<AssetsInMediaType>("niapm/v1/assets?skip=0&take=1000");
        }

        public async Task<int> GetConnectionDeviceCountAsync()
        {
            var data = await _dataService.GetAsync<AssetsInMediaType>("niapm/v1/assets?skip=0&take=1000");
            return data.totalCount;
        }
    }
}
