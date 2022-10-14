using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Services
{
    public class FPYService
    {
        private readonly DataService _dataService;

        public FPYService(DataService dataService)
        {
            _dataService = dataService;
        }

        public async Task GetAll()
        {
            var x = await _dataService.GetAllTestResult();
        
        }

    }
}
