using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Services
{
    public class CalibService
    {
        private readonly DataService _dataService;
        private readonly Logger _logger;

        public CalibService(DataService dataService, Logger logger)
        {
            _dataService = dataService;
            _logger = logger;
        }


    }
}
