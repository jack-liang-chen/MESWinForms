using MESWinForms.MediaTypes.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Services
{
    public class DAQService
    {
        private readonly DataService _dataService;
        private readonly Logger _logger;

        public DAQService(DataService dataService, Logger logger)
        {
            _dataService = dataService;
            _logger = logger;
        }

        public async Task<List<TagValue>> GetAllTagHistoryValues(string path)
        {
            var data = await _dataService.GetByPostAsync<TagHistoryInMediaType>("nitaghistorian/v2/tags/query-history", "{\"path\": \"" + path + "\"}");
            return data.values;
        }
    }
}
