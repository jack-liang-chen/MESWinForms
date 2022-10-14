using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Services
{
    public class FailedTestService
    {
        private readonly DataService _dataService;

        public FailedTestService(DataService dataService)
        {
            _dataService = dataService;
        }
    }
}
