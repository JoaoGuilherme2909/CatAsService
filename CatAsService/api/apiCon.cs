using Newtonsoft.Json;
using QuickType;
using RestSharp;
using System;

namespace CatAsService.api
{
    class ApiCon
    {
        private static string api_key = "YOUR_KEY";
        
        public static List<BreedsJson> apiGet(string breedId)
        {
            RestClient client = new RestClient("https://api.thecatapi.com/v1/images/search?breed_ids=" + breedId);
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

        public static void ApiPost(BreedsJson raca, string id)
        {
            RestClient client = new RestClient("https://api.thecatapi.com/v1/favourites");
            RestRequest request = new RestRequest("", Method.Post);
            request.AddHeader("x-api-key", api_key);
            request.AddBody(new {
                image_id = raca.Id,
                sub_id = id
            }); 
            RestResponse response = client.Execute(request);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Raça {raca.Breeds[0].Name}, salva com sucesso");
            }else
            {
                MessageBox.Show($"Ocorreu um erro: {response.ErrorException}"); 
            }

        }

        public static List<Favourites> GetFavourites()
        {
            RestClient client = new RestClient("https://api.thecatapi.com/v1/favourites");
            RestRequest request = new RestRequest("", Method.Get);
            request.AddHeader("x-api-key", api_key);
            RestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<Favourites> content = JsonConvert.DeserializeObject<List<Favourites>>(response.Content.ToString());
                return content;
            }
            else
            {
                return null;
            }

        }

        public static BreedsJson apiGetbyImage(string imageId)
        {
            RestClient client = new RestClient("https://api.thecatapi.com/v1/images/" + imageId);
            RestRequest request = new RestRequest("", Method.Get);
            request.AddHeader("x-api-key", api_key);
            RestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                BreedsJson content = JsonConvert.DeserializeObject<BreedsJson>(response.Content.ToString());
                return content;
            }
            else
            {
                return null;
            }
        }

        public static void DeleteFavourites(string id)
        {
            RestClient client = new RestClient($"https://api.thecatapi.com/v1/favourites?sub_id={id}");
            RestRequest request = new RestRequest("", Method.Delete);
            request.AddHeader("x-api-key", api_key);
            RestResponse response = client.Execute(request);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Deletado com Sucesso");
            }
            else
            {
                MessageBox.Show(response.ErrorException.ToString());
            }
        }

    }
}
