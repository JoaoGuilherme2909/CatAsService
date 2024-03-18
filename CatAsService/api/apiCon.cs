using Newtonsoft.Json;
using QuickType;
using RestSharp;
using System;

namespace CatAsService.api
{
    class ApiCon
    {
        public static List<BreedsJson> apiGet(string breedId)
        {
            string api_key = "live_9gfXsEfLLdyt66booQC0ik36OMebG5sDtmicv3OpciCQUVsXOFawdeKyrFygM86U";
            RestClient client = new RestClient($"https://api.thecatapi.com/v1/images/search?breed_ids={breedId}");
            RestRequest request = new RestRequest("", Method.Get);
            request.AddHeader("x-api-key", api_key);
            RestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<BreedsJson> content = JsonConvert.DeserializeObject<List<BreedsJson>>(response.Content.ToString());
                return content;
            }
            else
            {
                return null;
            }
        }

    }
}
