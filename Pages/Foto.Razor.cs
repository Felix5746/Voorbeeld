using System.Net.Http;
using Voorbeeld.models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;
using System.Net.Http.Json;

namespace Voorbeeld.Pages
{
    public partial class Foto
    {
        private readonly HttpClient httpClient = new HttpClient();
        public string Message { get; set; }
        public string Result { get; set; }
        public OMDBApiResponse Response { get; set; }
        public string Search { get; set; }
        public string MyAPIkey { get; set; }

        public Foto()
        {
            MyAPIkey = "3182762b";
        }

        public async void GetData()
        {
            var client = new HttpClient();
            var apiKey = MyAPIkey;
            var zoekterm = Search.Replace(" ", "%20");
            var url = $"https://www.omdbapi.com/?s={zoekterm}&apiKey={apiKey}&type=movie";
            Response = await client.GetFromJsonAsync<OMDBApiResponse>(url);
            Message = "Er zijn " + Response.Search.Count + " Films gevonden";
        }
    }
}