using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CatAsService.api
{
    class ViaCepCon
    {

        public static ViaCep2 apiGet(string cep)
        {
            RestClient client = new RestClient($"https://viacep.com.br/ws/{cep}/json/");
            RestRequest request = new RestRequest("", Method.Get);
            RestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string json = "{\"cep\":\"78148-060\",\"logradouro\":\"Rua Cachoeirinha\",\"complemento\":\"(Lot Jd O Verde)\",\"bairro\":\"Canelas\",\"localidade\":\"Várzea Grande\",\"uf\":\"MT\",\"ibge\":\"5108402\",\"gia\":\"\",\"ddd\":\"65\",\"siafi\":\"9167\"}";

                ViaCep2 content = JsonConvert.DeserializeObject<ViaCep2>(response.Content);
                MessageBox.Show(content.cep);
                MessageBox.Show(content.ToString());
                return content;

            }
            else
            {
                return null;
            }
        }

    }
}
