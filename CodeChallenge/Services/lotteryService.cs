using CodeChallenge.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace CodeChallenge.Services
{
    public class lotteryService : ILotteryService
    {
        private readonly string _ServiceURL;
        public lotteryService()
        {
            _ServiceURL = System.Configuration.ConfigurationManager.AppSettings["thelottServiceURL"];
        }


        public async Task<LatestLotteriesResultsResponse> GetLatestLotteriesResultsAsync(LotteriesResultsRequest request)
        {
            var json = JsonConvert.SerializeObject(request);

            var requestData = new StringContent(json, Encoding.UTF8, "application/json");

            var url = _ServiceURL + "/latestresults";

            // We can move the below code in a base class!
            using (var client = new HttpClient()) 
            { 

                var response = await client.PostAsync(url, requestData);

                var result = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<LatestLotteriesResultsResponse>(result);

                return await Task.FromResult(data);
        
            }
        }


       public async Task<OpenLotteriesDrawsResponse> GetOpenLotteriesDrawsAsync(OpenLotteriesDrawsRequest request)
        {
            var json = JsonConvert.SerializeObject(request);

            var requestData = new StringContent(json, Encoding.UTF8, "application/json");

            var url = _ServiceURL + "/opendraws";

            // We can move the below code in a base class!
            using (var client = new HttpClient())
            {

                var response = await client.PostAsync(url, requestData);

                var result = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<OpenLotteriesDrawsResponse>(result);

                return await Task.FromResult(data);

            }
        }
        
    }
}