using Newtonsoft.Json;
using RestSharp;
using System;

namespace CatAsService.api
{
    class ApiCon
    {
        public static CatModel apiGet(string breedId)
        {
            string api_key = "live_9gfXsEfLLdyt66booQC0ik36OMebG5sDtmicv3OpciCQUVsXOFawdeKyrFygM86U";
            RestClient client = new RestClient($"https://api.thecatapi.com/v1/images/search?breed_ids={breedId}");
            RestRequest request = new RestRequest("", Method.Get);
            request.AddHeader("x-api-key", api_key);
            RestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<CatModel> content = JsonConvert.DeserializeObject<List<CatModel>>(response.Content.ToString());
                return content[0];
              
            }
            else
            {
                return null;
            }
        }

    }
}
