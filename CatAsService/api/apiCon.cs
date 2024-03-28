using Newtonsoft.Json;
using api;
using RestSharp;
using System;

namespace CatAsService.api
{
    class ApiCon
    {
        private string api_key = "your_api_key";
        
        public List<BreedsJson> apiGet(string breedId)
        {
            RestClient client = new RestClient("https://api.thecatapi.com/v1/images/search?breed_ids=" + breedId);
            RestRequest request = new RestRequest("", Method.Get);
            request.AddHeader("x-api-key", api_key);
            RestResponse response = client.Execute(request);

            List<BreedsJson> content = JsonConvert.DeserializeObject<List<BreedsJson>>(response.Content.ToString());
            return content;
        }

        public void ApiPost(BreedsJson raca, string id)
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

        public List<Favourites> GetFavourites()
        {
            RestClient client = new RestClient("https://api.thecatapi.com/v1/favourites");
            RestRequest request = new RestRequest("", Method.Get);
            request.AddHeader("x-api-key", api_key);
            RestResponse response = client.Execute(request);
            List<Favourites> content = JsonConvert.DeserializeObject<List<Favourites>>(response.Content.ToString());
            return content;
        }

        public BreedsJson apiGetbyImage(string imageId)
        {
            RestClient client = new RestClient("https://api.thecatapi.com/v1/images/" + imageId);
            RestRequest request = new RestRequest("", Method.Get);
            request.AddHeader("x-api-key", api_key);
            RestResponse response = client.Execute(request);

            BreedsJson content = JsonConvert.DeserializeObject<BreedsJson>(response.Content.ToString());
            return content;
            
        }

        public void DeleteFavourites(string id)
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
