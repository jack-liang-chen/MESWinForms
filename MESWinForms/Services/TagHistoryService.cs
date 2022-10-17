using MESWinForms.MediaTypes.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Services
{
    public class TagHistoryService
    {
        private readonly DataService _dataService;

        public TagHistoryService(DataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<List<TagValue>> GetAllTagHistoryValues(string path)
        {
            var data = await _dataService.GetByPostAsync<TagHistoryInMediaType>("nitaghistorian/v2/tags/query-history", "{\"path\": \"" + path + "\"}");
            return data.values;
        }
    }
}
