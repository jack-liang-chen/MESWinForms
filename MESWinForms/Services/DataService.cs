using MESWinForms.MediaTypes.In;
using MESWinForms.MediaTypes.In.Alarm;
using MESWinForms.MediaTypes.In.TestResult;
using RestSharp;
using RestSharp.Authenticators;
using System.Configuration;
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

        public async Task<T> GetAsync<T>(string resource)
        {
            var request = new RestRequest(resource);
            var response = await _client.GetAsync<T>(request);

            return response;
        }

        public async Task<T> GetByPostAsync<T>(string resource, string postBodyContent)
        {
            var request = new RestRequest(resource).AddJsonBody(postBodyContent);
            var response = await _client.PostAsync<T>(request);

            return response;
        }
    }
}
