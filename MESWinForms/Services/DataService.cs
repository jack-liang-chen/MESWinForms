using MESWinForms.MediaTypes.In;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Services
{
    public class DataService
    {
        private readonly RestClient _client;

        public DataService()
        {
            var server = ConfigurationManager.AppSettings["SystemLinkServer"].Trim();
            var account = ConfigurationManager.AppSettings["Account"].Trim();
            var password = ConfigurationManager.AppSettings["Password"];

            _client = new RestClient(server)
            {
                Authenticator = new HttpBasicAuthenticator(account, password)
            };
        }

        public async Task<AlarmInMediaType> GetAllAsync(string resource)
        {
            var request = new RestRequest(resource).AddJsonBody("{}");
            var response = await _client.PostAsync<AlarmInMediaType>(request);

            return response;
        }
    }
}
