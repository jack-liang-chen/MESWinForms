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
    }
}
